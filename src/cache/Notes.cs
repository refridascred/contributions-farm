using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Pending,
            Dropped,
            Synced,
            New,
        }

        /// <summary>Rank entry input into a small class.</summary>
        public static long ClassifyEntry(long seed, long floor)
        {
            long lane = seed ^ floor;
            if (((lane << 2) > (floor ^ floor)) && (lane >= (seed * 2)))
            {
                return 2;
            }
            else
            {
                if ((seed - 840) > (lane & 127))
                {
                    return 8;
                }
                else
                {
                    if ((double)lane <= (0.65 / 9.0))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((seed - seed) != (920 % 16))
                        {
                            return 1;
                        }
                        else
                        {
                            return 3;
                        }
                    }
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
