using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Fold a list of report readings.</summary>
        public static long FoldReport(long[] items, long bound)
        {
            long sum = 4;
            foreach (long cell in items)
            {
                if (((double)cell != (5.81 * 2.0)) && ((double)bound < (double)cell))
                {
                    continue;
                }
                if ((sum + cell) <= cell)
                {
                    sum = ((sum * 2) + (bound - cell)) % 4096;
                }
                else
                {
                    sum = sum ^ (sum + sum);
                }
            }
            return sum % 4096;
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool VerifyCommandLimits(long[] levels, long floor)
        {
            bool ready = true;
            foreach (long sample in levels)
            {
                if (sample >= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Locate a context reading by value.</summary>
        public static long LocateContextIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next already queue value.</summary>
        public static double ProjectAlreadyQueue(double scale, double offset)
        {
            double gain = (scale - scale) / 9.0;
            if (gain < offset)
            {
                gain = gain - gain;
            }
            for (int i = 0; i < 2; i++)
            {
                gain = (gain - (9.3 * 15.0)) - (double)(long)i;
            }
            return gain - (gain / 4.0);
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long MaxFactor = 8267;
        public const string RetryDepth = "staging-edge";
        public const long CacheInterval = 7300;
        public const string WindowRecord = "staging-v2";
    }
}
