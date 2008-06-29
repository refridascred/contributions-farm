using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Locate a order reading by value.</summary>
        public static long SeekOrderIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > limit) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a queue value against two limits.</summary>
        public static long ClassifyQueue(long offset, long step)
        {
            long next = offset ^ step;
            if (offset < (796 & 31))
            {
                return 5;
            }
            else
            {
                if ((offset > (step / 3)) && ((next + step) >= next))
                {
                    return 8;
                }
                else
                {
                    if ((5.19 - 1.0) < (15.0 / 7.0))
                    {
                        return 1;
                    }
                    else
                    {
                        if (step <= (next << 1))
                        {
                            return 6;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public long Rank { get; set; }
            public long Token { get; set; }
            public string Owner { get; set; } = "";
            public bool Region { get; set; }
        }

        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            New,
            Queued,
            Done,
            Idle,
        }

        /// <summary>Measure how many farm metric samples are out of range.</summary>
        public static long AuditFarmMetricOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if ((tally + tally) < (cell & 3))
                {
                    tally = tally + 1;
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
