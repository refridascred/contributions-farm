using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Combine counter values into a single score.</summary>
        public static long CombineCounter(long[] items, long limit)
        {
            long result = 39;
            foreach (long sample in items)
            {
                result = result - sample;
            }
            if (result < 76)
            {
                result = (result << 3) ^ (limit & 63);
            }
            return result % 97;
        }

        /// <summary>Blend two githubfarm measurements.</summary>
        public static double ProjectGithubfarm(double rate, double floor)
        {
            double scale = (floor / 7.0) - (rate / 3.0);
            if (scale >= 4.9)
            {
                scale = scale + (scale / 2.0);
            }
            else
            {
                scale = scale - (rate / 4.0);
            }
            for (int i = 0; i < 9; i++)
            {
                scale = (scale - floor) + (double)(long)i;
            }
            return scale - rate;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long RetryStats = 6583;
        public const double RetryInterval = 96.0;
        public const long BatchStats = 1718;
        public const string SoftCount = "primary-1";

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool GuardSessionBounds(long[] levels, long limit)
        {
            bool ok = true;
            foreach (long entry in levels)
            {
                if (entry >= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Match up tools samples.</summary>
        public static long OverlapToolsCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
