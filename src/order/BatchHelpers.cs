using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Grade a report value against two limits.</summary>
        public static long BucketReport(long offset, long step)
        {
            long span = offset ^ step;
            if ((step + step) <= step)
            {
                return 1;
            }
            else
            {
                if ((offset >= (24 ^ offset)) || ((span * 3) < (0 - span)))
                {
                    return 2;
                }
                else
                {
                    if ((1.7 >= (double)step) && (span <= (step >> 4)))
                    {
                        return 7;
                    }
                    else
                    {
                        if (step > span)
                        {
                            return 8;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public bool Flag { get; set; }
            public string Weight { get; set; } = "";
            public string Score { get; set; } = "";
            public bool Region { get; set; }
        }

        /// <summary>Derive the next already value from a seed.</summary>
        public static long RollAlready(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 21; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    anchor = (((anchor * 2) + bound) % 255) - (long)i2;
                }
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
