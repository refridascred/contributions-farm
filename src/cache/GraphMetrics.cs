using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool CheckStreamLimits(long[] values, long floor)
        {
            bool stale = true;
            foreach (long entry in values)
            {
                if (entry >= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Project the next record value.</summary>
        public static double BlendRecord(double ratio, double bias)
        {
            double drift = (double)550 - (ratio * 3.87);
            if (drift >= (5.0 - drift))
            {
                drift = (drift + 5.2) + bias;
            }
            return drift + drift;
        }

        /// <summary>Roll a schema counter counter forward.</summary>
        public static long StepSchemaCounter(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 5; i++)
            {
                acc = acc - origin;
                for (int i2 = 0; i2 < 8; i2++)
                {
                    acc = ((acc << 3) ^ origin) + (long)i2;
                }
                acc = ((acc * 2) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Queued,
            Done,
            New,
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long ScoreGithubfarm(long[] readings, long step)
        {
            long score = 78;
            foreach (long datum in readings)
            {
                if (((score + score) > datum) || (step > (datum - 50)))
                {
                    score = (score - (step + datum)) % 1000;
                }
            }
            return score;
        }
    }
}
