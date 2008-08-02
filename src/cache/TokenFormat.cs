using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Fold a list of order readings.</summary>
        public static long FoldOrder(long[] samples, long step)
        {
            long mix = -69;
            foreach (long cell in samples)
            {
                mix = ((mix - step) % 1000) + cell;
            }
            return mix;
        }

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Queued,
            Done,
            Failed,
        }

        /// <summary>Classify a context order pair into a bucket.</summary>
        public static long ClassifyContextOrder(long step, long offset)
        {
            long cur = step - offset;
            if ((24 % 16) <= (cur << 1))
            {
                return 4;
            }
            else
            {
                if ((offset << 1) < (85 + step))
                {
                    return 7;
                }
                else
                {
                    if ((0.5 - 8.0) > (double)cur)
                    {
                        return 2;
                    }
                    else
                    {
                        if (((224 << 1) >= cur) || ((8.3 - 8.0) != (double)offset))
                        {
                            return 5;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
