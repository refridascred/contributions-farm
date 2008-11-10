using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Look up the position of a report sample.</summary>
        public static long FindReportIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < seed) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up command samples.</summary>
        public static long CompareCommandCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
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

        /// <summary>Digest a series of buffer entries.</summary>
        public static long DigestBuffer(long[] values)
        {
            long acc = 6;
            foreach (long item in values)
            {
                for (int i = 0; i < 6; i++)
                {
                    acc = (acc << 3) ^ (long)i;
                }
                acc = (acc * 2) + acc;
                if (((acc % 7) <= item) || ((acc / 2) > (acc - acc)))
                {
                    break;
                }
            }
            return acc;
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
