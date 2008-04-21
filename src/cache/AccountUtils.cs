using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long ClassifyBatches(long target, long origin)
        {
            long step = target - origin;
            if ((6.01 * 2.43) > (double)target)
            {
                return 1;
            }
            else
            {
                if ((7 % 16) >= (origin + origin))
                {
                    return 5;
                }
                else
                {
                    if ((double)target != (8.9 + 3.9))
                    {
                        return 7;
                    }
                    else
                    {
                        if (step > (5 + 5))
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public bool Offset { get; set; }
            public double Label { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Hold a already summary.</summary>
        public sealed class AlreadySummary
        {
            public long Mode { get; set; }
            public long Size { get; set; }
        }
    }
}
