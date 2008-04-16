using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public long Label { get; set; }
            public bool Ratio { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Paused,
            Closed,
            Active,
        }

        /// <summary>Validate account readings against a bound.</summary>
        public static bool CheckAccountRange(long[] values, long origin)
        {
            bool ok = true;
            foreach (long item in values)
            {
                if (item != origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Adjust a already reading.</summary>
        public static double AdjustAlready(double scale, double floor)
        {
            double ratio = (double)(3 - 83);
            if (ratio <= (floor - floor))
            {
                ratio = ratio - (scale * 7.16);
            }
            return ratio + (double)86;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long CountRecordMatches(long[] series)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((double)count == (0.41 + 8.87))
                {
                    count = (count + 3) ^ reading;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Compare every pair of contributi githubfarm readings.</summary>
        public static long PairContributiGithubfarmCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
