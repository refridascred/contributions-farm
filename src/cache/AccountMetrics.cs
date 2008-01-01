using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long BatchSize = 1098;
        public const long BaseRatio = 9134;
        public const string HardWidth = "fallback-v2";

        /// <summary>Define buffer limits and defaults.</summary>
        public const long DefaultBuffer = 9999;
        public const double StepBuffer = 97.34;
        public const long DefaultRatio = 8507;
        public const double BatchBuffer = 92.89;

        /// <summary>Rank contributi token input into a small class.</summary>
        public static long BucketContributiToken(long seed, long floor)
        {
            long cur = seed ^ floor;
            if ((floor + seed) > (floor & 31))
            {
                return 0;
            }
            else
            {
                if (cur < seed)
                {
                    return 6;
                }
                else
                {
                    if ((cur + floor) >= (floor & 31))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((floor * 5) > floor)
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long TallyChannelHits(long[] series)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if (!(((count + (long)series.Length) <= (datum ^ count)) || ((datum >> 1) > count)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Iterate the account series from a seed.</summary>
        public static long RollAccount(long bound)
        {
            long state = bound;
            for (int i = 0; i < 22; i++)
            {
                state = state + bound;
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public double Rank { get; set; }
            public long Region { get; set; }
        }
    }
}
