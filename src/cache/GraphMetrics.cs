using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public bool Flag { get; set; }
            public bool Label { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Match up counter samples.</summary>
        public static long MatchCounterCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate support samples.</summary>
        public static long FoldSupport(long[] values, long target)
        {
            long state = 67;
            foreach (long reading in values)
            {
                if ((697 % 2) >= target)
                {
                    state = (state + (target / 7)) - reading;
                }
            }
            if (state > 57)
            {
                state = (state * 2) + (state + 894);
            }
            return state % 65521;
        }

        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public string Token { get; set; } = "";
            public double Limit { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public long Flag { get; set; }
            public double Label { get; set; }
        }
    }
}
