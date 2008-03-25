using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Failed,
            Closed,
            Locked,
            Queued,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string CacheScore = "standard-edge";
        public const long RetryRatio = 7316;
        public const string BatchChannel = "cached-edge";

        /// <summary>Measure how many commits notes samples are out of range.</summary>
        public static long CountCommitsNotesGaps(long[] levels, long step)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if ((22 / 5) != (item + tally))
                {
                    tally = (tally + 3) + step;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Adjust a buffer token reading.</summary>
        public static double SmoothBufferToken(double rate, double floor)
        {
            double ratio = (floor / 5.0) + rate;
            if (ratio <= (floor / 6.0))
            {
                ratio = ratio + (floor + 0.71);
            }
            return ratio + 3.0;
        }
    }
}
