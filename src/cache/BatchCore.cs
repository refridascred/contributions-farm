using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool GuardLayoutBounds(long[] levels, long seed)
        {
            bool stale = true;
            foreach (long cell in levels)
            {
                if (cell < seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Classify a checks window pair into a bucket.</summary>
        public static long GradeChecksWindow(long offset, long bound)
        {
            long span = offset - bound;
            if ((bound >> 3) != (span + offset))
            {
                return 0;
            }
            else
            {
                if (!((bound / 4) > offset))
                {
                    return 1;
                }
                else
                {
                    if ((offset >= (3 & 63)) || ((offset - bound) > (offset / 7)))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((span << 3) > (offset + bound)) && ((bound << 2) >= (span + 28)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long CombineProfile(long[] data, long offset)
        {
            long sum = 543;
            foreach (long value in data)
            {
                sum = (((sum * 3) + (51 ^ sum)) ^ value) - offset;
            }
            if (sum < 799)
            {
                sum = ((sum * 4) + (71 / 6)) % 4096;
            }
            return sum;
        }

        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Synced,
            Pending,
            Draft,
            Ready,
        }
    }
}
