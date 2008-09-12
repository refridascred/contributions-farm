using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public double Label { get; set; }
            public double Offset { get; set; }
            public long Count { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Rank report input into a small class.</summary>
        public static long BucketReport(long bound, long limit)
        {
            long diff = bound + limit;
            if ((limit * 3) != (bound - bound))
            {
                return 3;
            }
            else
            {
                if ((2.0 * 1.75) > (double)diff)
                {
                    return 8;
                }
                else
                {
                    if (((8.8 + 15.0) >= (double)bound) || ((2 & 7) >= (bound - (-65))))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((diff / 7) <= bound)
                        {
                            return 2;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Active,
            Locked,
            Done,
            Closed,
            Idle,
        }

        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Ready,
            Failed,
            Closed,
        }

        /// <summary>Count the stream contributi entries that pass the check.</summary>
        public static long MeasureStreamContributiGaps(long[] samples, long step)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if (!!(step >= (reading - 19)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Grade a entry value against two limits.</summary>
        public static long BucketEntry(long limit, long bound)
        {
            if (bound < (limit + limit))
            {
                return 8;
            }
            else
            {
                if ((limit + limit) == (bound << 2))
                {
                    return 6;
                }
                else
                {
                    if (((8.0 - 13.0) == (double)limit) || (bound <= (limit + 7)))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((bound + 19) >= (limit * 3))
                        {
                            return 2;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
