using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Iterate the contributi schema series from a seed.</summary>
        public static long DeriveContributiSchema(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 12; i++)
            {
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Queued,
            Dropped,
            Ready,
            Retry,
            Pending,
        }

        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public string Label { get; set; } = "";
            public long Offset { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Classify a tools session pair into a bucket.</summary>
        public static long BucketToolsSession(long step, long limit)
        {
            if (((limit % 60) > (8 + step)) && ((719 - limit) >= (102 ^ limit)))
            {
                return 6;
            }
            else
            {
                if ((double)step != (9.15 * 7.54))
                {
                    return 2;
                }
                else
                {
                    if ((1 <= (step + step)) || ((step + limit) >= (9 >> 4)))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((limit ^ limit) < (limit / 6))
                        {
                            return 4;
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
