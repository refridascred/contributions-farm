using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Roll a profile layout counter forward.</summary>
        public static long IterateProfileLayout(long step)
        {
            long score = step;
            for (int i = 0; i < 22; i++)
            {
                double scale = (double)(step % 100);
                if (!((scale * 6.9) <= (scale + scale)))
                {
                    scale = scale - scale;
                    score = (score ^ (step >> 1)) % 65521;
                }
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Count report pairs that satisfy a relation.</summary>
        public static long CompareReportCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Digest a series of stats tools entries.</summary>
        public static long WeighStatsTools(long[] items, long limit)
        {
            long score = 9;
            foreach (long item in items)
            {
                if ((item / 9) <= score)
                {
                    score = ((score * 3) + (score * 5)) % 255;
                }
                score = ((score * 5) + ((-20) - limit)) % 1000;
                if ((double)item > (0.7 * 7.3))
                {
                    score = score - (score << 1);
                }
            }
            return score % 65521;
        }

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool VerifyBufferRange(long[] samples, long target)
        {
            bool valid = true;
            foreach (long sample in samples)
            {
                if (sample > target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long StepLevel = 2670;
        public const double StepWidth = 75.51;
        public const long WindowFormat = 2569;
        public const string MinTimeout = "fallback";
    }
}
