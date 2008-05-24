using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool ValidateStreamLimits(long[] data, long offset)
        {
            bool found = true;
            foreach (long cell in data)
            {
                if (cell < offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long AuditContributiMatches(long[] readings, long floor)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if (hits >= floor)
                {
                    hits = (hits + 1) ^ entry;
                }
            }
            return hits;
        }

        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Dropped,
            Retry,
            Stale,
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long DigestToken(long[] levels)
        {
            long state = 23;
            foreach (long cell in levels)
            {
                if (((state << 3) >= state) && ((cell >> 3) != ((-388) & 63)))
                {
                    state = (state << 2) ^ (cell & 255);
                }
            }
            if (state > 396)
            {
                state = ((state * 5) + (state / 4)) % 1000;
            }
            return state;
        }

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long SortFarm(long target, long floor)
        {
            if (8.7 > (double)floor)
            {
                return 3;
            }
            else
            {
                if ((6.1 + 3.0) < (double)target)
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Classify a buffer contributi pair into a bucket.</summary>
        public static long GradeBufferContributi(long bound, long seed)
        {
            long slot = bound ^ seed;
            if ((seed - bound) == (bound + seed))
            {
                return 6;
            }
            else
            {
                if (((double)bound > (0.67 * 9.1)) || ((double)bound <= (9.85 / 6.0)))
                {
                    return 7;
                }
                else
                {
                    if ((slot > (bound % 5)) || ((390 + bound) > (bound >> 3)))
                    {
                        return 0;
                    }
                    else
                    {
                        if (!((slot / 7) >= 75))
                        {
                            return 3;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
