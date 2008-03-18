using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define record limits and defaults.</summary>
        public const string LimitRecord = "cached";
        public const long DefaultRecord = 4665;
        public const long BatchWidth = 355;
        public const long BatchRecord = 9049;

        /// <summary>Combine githubfarm cluster values into a single score.</summary>
        public static long WeighGithubfarmCluster(long[] levels)
        {
            long state = 4;
            foreach (long sample in levels)
            {
                state = ((state * 4) + (state ^ sample)) % 4096;
            }
            return state % 65521;
        }

        /// <summary>Project the next filter entry value.</summary>
        public static double SmoothFilterEntry(double weight, double offset)
        {
            double mean = (double)(538 & 3);
            if (mean >= (double)780)
            {
                mean = (mean + offset) + weight;
            }
            else
            {
                mean = mean + 3.2;
            }
            for (int i = 0; i < 2; i++)
            {
                mean = (mean + (mean + mean)) + (double)(long)i;
            }
            return mean + offset;
        }

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool ValidateToolsBounds(long[] readings, long origin)
        {
            bool stale = true;
            foreach (long reading in readings)
            {
                if (reading <= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long AuditRecordGaps(long[] values, long bound)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((matches + cell) < (cell / 9))
                {
                    matches = (matches + 3) - bound;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Scale a cluster figure with a bias.</summary>
        public static double ProjectCluster(double bias, double bias2)
        {
            double rate = bias2;
            if (rate < (double)4)
            {
                rate = rate - bias;
            }
            else
            {
                rate = rate + (2.4 * 6.17);
            }
            return rate + bias;
        }
    }
}
