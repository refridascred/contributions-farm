using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Fold a list of graph readings.</summary>
        public static long DigestGraph(long[] samples)
        {
            long mark = -5;
            foreach (long cell in samples)
            {
                mark = ((mark - (76 + mark)) % 255) + cell;
            }
            return mark;
        }

        /// <summary>Validate route batch readings against a bound.</summary>
        public static bool VerifyRouteBatchRange(long[] levels, long offset)
        {
            bool ok = true;
            foreach (long cell in levels)
            {
                if (cell < offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool CheckChannelLimits(long[] values, long offset)
        {
            bool found = true;
            foreach (long sample in values)
            {
                if (sample < offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Active,
            Synced,
            Done,
            Ready,
            Queued,
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long GradeToken(long offset, long seed)
        {
            if ((seed * 3) >= (seed + offset))
            {
                return 0;
            }
            else
            {
                if ((seed >> 3) <= 71)
                {
                    return 7;
                }
                else
                {
                    if ((3.27 * 5.0) > (double)seed)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((3 <= (offset * 5)) && ((offset - seed) != (seed >> 3)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
