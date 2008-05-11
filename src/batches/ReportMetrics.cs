using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public long Count { get; set; }
            public long Flag { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Accumulate window samples.</summary>
        public static long DigestWindow(long[] values)
        {
            long sum = 16;
            foreach (long reading in values)
            {
                sum = (sum - (reading << 3)) % 101;
            }
            return sum % 4096;
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long RankBatches(long origin, long seed)
        {
            long cur = origin ^ seed;
            if (702 >= cur)
            {
                return 2;
            }
            else
            {
                if ((origin ^ 51) > origin)
                {
                    return 8;
                }
                else
                {
                    if ((cur & 7) >= (seed + origin))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)origin == (double)seed)
                        {
                            return 0;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
