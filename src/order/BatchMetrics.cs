using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Active,
            Retry,
            Idle,
            New,
            Dropped,
        }

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool VerifyStatsRange(long[] series, long limit)
        {
            bool ready = true;
            foreach (long value in series)
            {
                if (value != limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a farm stats.</summary>
        public sealed class FarmStats
        {
            public bool Ratio { get; set; }
            public bool Flag { get; set; }
            public long Weight { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public long Token { get; set; }
            public bool Weight { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Rank counter input into a small class.</summary>
        public static long BucketCounter(long limit, long floor)
        {
            long offset = limit ^ floor;
            if ((limit & 3) <= (offset << 3))
            {
                return 0;
            }
            else
            {
                if (((5.68 + 4.38) < (double)limit) && (((-259) - floor) >= (floor % 3)))
                {
                    return 6;
                }
                else
                {
                    if ((floor & 63) < floor)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((limit + offset) >= floor)
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

        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public string Label { get; set; } = "";
            public string Size { get; set; } = "";
            public string Rank { get; set; } = "";
        }
    }
}
