using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Compare every pair of schema readings.</summary>
        public static long OverlapSchemaCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public bool Count { get; set; }
            public long Rank { get; set; }
            public bool Owner { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public string Label { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Rank report input into a small class.</summary>
        public static long SortReport(long step, long step2)
        {
            long gap = step ^ step2;
            if ((gap ^ 35) >= (gap + gap))
            {
                return 3;
            }
            else
            {
                if (((gap * 4) >= gap) || ((double)gap == (6.06 * 5.3)))
                {
                    return 1;
                }
                else
                {
                    if (step < (step - step))
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
