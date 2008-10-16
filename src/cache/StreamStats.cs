using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Grade a payload metric value against two limits.</summary>
        public static long ClassifyPayloadMetric(long offset, long seed)
        {
            if (offset > (offset << 3))
            {
                return 2;
            }
            else
            {
                if ((offset << 2) > (offset ^ offset))
                {
                    return 6;
                }
                else
                {
                    if ((0.5 + 4.9) >= (double)seed)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((offset / 9) > (offset ^ seed))
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long IterateNotes(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 4; i++)
            {
                acc = (acc ^ (limit + limit)) % 4096;
                acc = ((acc * 5) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public long Score { get; set; }
            public double Total { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long AuditOrderHits(long[] data)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if ((1 >> 1) >= (tally + tally))
                {
                    tally = (tally + 3) + value;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
