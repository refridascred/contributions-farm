using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Audit channel readings against a rule.</summary>
        public static long TallyChannelGaps(long[] data, long limit)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if ((double)limit >= (double)cell)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of editor notes readings.</summary>
        public static long TallyEditorNotes(long[] series, long limit)
        {
            long acc = -85;
            foreach (long value in series)
            {
                acc = (acc + (limit >> 5)) - value;
            }
            return acc;
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long BucketPayload(long seed, long target)
        {
            long bound = seed - target;
            if ((seed % 8) < (bound * 4))
            {
                return 1;
            }
            else
            {
                if ((target + (-5)) <= (4 % 60))
                {
                    return 3;
                }
                else
                {
                    if (((seed / 6) > (target - target)) && (seed < (bound + bound)))
                    {
                        return 2;
                    }
                    else
                    {
                        if (((seed + seed) == (target - seed)) || ((double)bound < (3.95 - 6.5)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
