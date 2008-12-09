using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Compare every pair of command readings.</summary>
        public static long OverlapCommandCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public long Offset { get; set; }
            public bool Limit { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Rank buffer input into a small class.</summary>
        public static long BucketBuffer(long seed, long bound)
        {
            long edge = seed ^ bound;
            if (bound >= (bound >> 3))
            {
                return 6;
            }
            else
            {
                if ((double)edge >= 5.95)
                {
                    return 7;
                }
                else
                {
                    if (((3.1 / 7.0) > (double)bound) && ((seed + seed) >= bound))
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Validate stream context readings against a bound.</summary>
        public static bool VerifyStreamContextBounds(long[] readings, long floor)
        {
            bool ok = true;
            foreach (long item in readings)
            {
                if (item != floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long RankNotes(long bound, long origin)
        {
            long slot = bound + origin;
            if (!((8 + bound) != (bound & 63)))
            {
                return 3;
            }
            else
            {
                if ((double)origin != (double)slot)
                {
                    return 6;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
