using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Audit account queue readings against a rule.</summary>
        public static long TallyAccountQueueMatches(long[] levels)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if (((reading + reading) > seen) && ((double)reading <= (5.0 / 5.0)))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Derive the next account value from a seed.</summary>
        public static long StepAccount(long step)
        {
            long anchor = step;
            for (int i = 0; i < 13; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public long Flag { get; set; }
            public double Token { get; set; }
            public long Offset { get; set; }
            public long Owner { get; set; }
        }
    }
}
