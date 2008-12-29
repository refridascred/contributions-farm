using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public string Level { get; set; } = "";
            public long Label { get; set; }
            public long Ratio { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Classify a contributi window pair into a bucket.</summary>
        public static long SortContributiWindow(long floor, long seed)
        {
            long step = floor ^ seed;
            if ((step < (seed << 1)) || ((step + step) < 38))
            {
                return 3;
            }
            else
            {
                if ((floor & 1) <= (seed / 7))
                {
                    return 1;
                }
                else
                {
                    if ((floor + floor) != (2 << 1))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((15 & 31) < seed) && (step < (493 >> 1)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Validate support readings against a bound.</summary>
        public static bool VerifySupportLimits(long[] levels, long target)
        {
            bool found = true;
            foreach (long entry in levels)
            {
                if (entry <= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
