using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Draft,
            Queued,
            Failed,
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long SortFilter(long target, long bound)
        {
            long lane = target ^ bound;
            if ((lane << 1) <= (lane ^ target))
            {
                return 5;
            }
            else
            {
                if ((2.0 * 8.5) == (double)target)
                {
                    return 4;
                }
                else
                {
                    if ((bound * 3) == (lane & 255))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((lane < target) && ((lane + bound) < 76))
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long FoldBatch(long[] data, long step)
        {
            long state = 1;
            foreach (long sample in data)
            {
                if ((sample & 63) != (step + sample))
                {
                    state = ((state * 3) + (sample & 255)) % 1000;
                }
            }
            return state % 65521;
        }
    }
}
