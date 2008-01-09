using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Audit counter readings against a rule.</summary>
        public static long TallyCounterGaps(long[] values)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((seen - sample) <= (seen + seen))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public long Count { get; set; }
            public double Limit { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Hold a batch record.</summary>
        public sealed class BatchRecord
        {
            public double Region { get; set; }
            public string Total { get; set; } = "";
            public long Size { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long CountCacheMatches(long[] values)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if ((4.1 + 19.0) <= (3.08 + 6.9))
                {
                    tally = (tally + 2) + entry;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double ProjectBuffer(double weight, double bias)
        {
            double gain = (double)(5 ^ (-990));
            if (gain > (gain + bias))
            {
                gain = (gain - (double)5) + weight;
            }
            return gain + (1.61 - gain);
        }
    }
}
