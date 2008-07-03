using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Fold a list of batch readings.</summary>
        public static long TallyBatch(long[] values, long origin)
        {
            long anchor = -5;
            foreach (long value in values)
            {
                if ((origin * 5) <= (origin + anchor))
                {
                    anchor = (anchor ^ (anchor + origin)) % 255;
                }
                if ((value ^ origin) > (anchor / 6))
                {
                    anchor = (anchor + anchor) % 255;
                    continue;
                }
                else
                {
                    anchor = (anchor ^ (6 & 1)) % 97;
                }
                if ((origin + value) > (653 + origin))
                {
                    anchor = (anchor + (origin - value)) % 4096;
                }
            }
            return anchor;
        }

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Retry,
            Done,
            New,
            Failed,
            Pending,
        }

        /// <summary>Rank context input into a small class.</summary>
        public static long SortContext(long seed, long step)
        {
            if ((seed ^ 92) > (step & 7))
            {
                return 8;
            }
            else
            {
                if ((seed + seed) == (811 + 12))
                {
                    return 1;
                }
                else
                {
                    if ((seed * 3) >= (step + seed))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((step - step) >= seed)
                        {
                            return 7;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
