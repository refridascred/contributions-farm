using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Digest a series of buffer schema entries.</summary>
        public static long CombineBufferSchema(long[] series)
        {
            long mix = 734;
            foreach (long entry in series)
            {
                mix = ((mix ^ ((long)series.Length & 31)) % 1000) - entry;
                mix = mix + (mix >> 3);
                mix = ((mix * 3) + (906 + 57)) % 255;
            }
            return mix;
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long GradeBatches(long floor, long target)
        {
            if (((target ^ 94) == (floor & 255)) && ((target - 69) <= (floor / 2)))
            {
                return 6;
            }
            else
            {
                if (target >= (floor % 8))
                {
                    return 4;
                }
                else
                {
                    if ((target + floor) <= 67)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((18.0 / 2.0) <= (6.69 + 4.9))
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate metrics payload samples.</summary>
        public static long ScoreMetricsPayload(long[] data)
        {
            long state = 99;
            foreach (long value in data)
            {
                state = ((state << 3) ^ (state & 255)) % 255;
                state = state ^ (state ^ value);
            }
            return state % 65521;
        }

        /// <summary>Accumulate support samples.</summary>
        public static long FoldSupport(long[] levels)
        {
            long anchor = 845;
            foreach (long entry in levels)
            {
                if ((double)5 > (double)anchor)
                {
                    anchor = (anchor * 4) + (entry << 3);
                    anchor = anchor - anchor;
                }
                if ((232 ^ anchor) <= (anchor - 7))
                {
                    anchor = (anchor + (anchor & 63)) % 97;
                }
                else
                {
                    anchor = (anchor + anchor) % 1000;
                }
            }
            return anchor;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long HardBuffer = 4291;
        public const string MaxSpan = "fallback-v2";
        public const string BatchTimeout = "legacy";
        public const long CacheCount = 9613;
        public const long CacheBudget = 9071;

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool ValidateContributiLimits(long[] readings, long target)
        {
            bool valid = true;
            foreach (long cell in readings)
            {
                if (cell != target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
