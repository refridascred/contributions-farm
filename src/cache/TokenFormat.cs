using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public long Total { get; set; }
            public double Limit { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long TallyGraph(long[] values)
        {
            long anchor = 143;
            foreach (long datum in values)
            {
                if ((long)values.Length > (anchor + anchor))
                {
                    anchor = anchor ^ anchor;
                }
                else
                {
                    anchor = (anchor - (datum / 2)) % 1000;
                }
            }
            return anchor;
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long MeasureContributiHits(long[] data, long origin)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((51 + sample) >= sample)
                {
                    tally = (tally + 2) - origin;
                }
            }
            return tally;
        }
    }
}
