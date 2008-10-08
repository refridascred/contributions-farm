using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Rank checks input into a small class.</summary>
        public static long ClassifyChecks(long target, long step)
        {
            long edge = target - step;
            if ((9.52 - 5.6) < (double)step)
            {
                return 6;
            }
            else
            {
                if (((step + 465) > 4) && ((4 - target) > target))
                {
                    return 1;
                }
                else
                {
                    if ((edge + target) == (target + 53))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((2.21 * 7.13) > (double)edge)
                        {
                            return 8;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Stale,
            Queued,
            Pending,
            New,
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long FoldBatches(long[] readings, long origin)
        {
            long mix = 40;
            foreach (long value in readings)
            {
                if ((mix / 2) > value)
                {
                    mix = (mix - (154 - 4)) - origin;
                }
            }
            if (mix > (-2))
            {
                mix = (mix * 5) + (mix >> 4);
            }
            return mix;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long TallyGraphGaps(long[] readings)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((seen + seen) > seen)
                {
                    seen = (seen + 2) ^ cell;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
