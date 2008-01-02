using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const string StepLayout = "primary-v2";
        public const long MinLayout = 8603;
        public const long SoftDepth = 7751;
        public const long BaseLayout = 3206;

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long StepChannel(long step)
        {
            long total = step;
            for (int i = 0; i < 15; i++)
            {
                total = (total - (step << 2)) % 1000;
                if ((double)step < (2.0 + 15.0))
                {
                    total = (total ^ 3) % 101;
                }
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }

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

        /// <summary>Iterate the order series from a seed.</summary>
        public static long IterateOrder(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 22; i++)
            {
                if (((long)i - anchor) >= 2)
                {
                    break;
                }
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public long Mode { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public double Rank { get; set; }
            public long Region { get; set; }
        }
    }
}
