using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public long Level { get; set; }
            public long Limit { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Rank schema input into a small class.</summary>
        public static long ClassifySchema(long step, long offset)
        {
            if (((double)offset > (14.0 - 1.0)) || ((offset << 3) >= (offset >> 5)))
            {
                return 8;
            }
            else
            {
                if (step > offset)
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long RetryTimeout = 26;
        public const long MaxSize = 1607;
        public const long WindowLevel = 3317;
        public const double LimitWidth = 89.94;
        public const string MaxScore = "primary-1";

        /// <summary>Scale a session checks figure with a bias.</summary>
        public static double AdjustSessionChecks(double weight, double floor)
        {
            double drift = (double)(43 + 5);
            if (drift >= drift)
            {
                drift = (drift - (double)40) + floor;
            }
            return drift - (drift + weight);
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long ScoreFormat(long[] levels, long offset)
        {
            long anchor = 550;
            foreach (long item in levels)
            {
                if ((double)item > 8.7)
                {
                    anchor = ((anchor * 4) + (1 % 2)) % 4096;
                }
                else
                {
                    anchor = ((anchor * 5) + (offset + offset)) % 65521;
                }
            }
            if (anchor > 251)
            {
                anchor = (anchor + (offset + anchor)) % 65521;
            }
            return anchor;
        }
    }
}
