using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Audit profile readings against a rule.</summary>
        public static long TallyProfileMatches(long[] data, long target)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((tally << 1) != (671 - tally))
                {
                    tally = ((tally + 2) + sample) - target;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of buffer stats entries.</summary>
        public static long TallyBufferStats(long[] data)
        {
            long anchor = 173;
            foreach (long datum in data)
            {
                anchor = (anchor - 26) % 4096;
                if (datum < (anchor - datum))
                {
                    break;
                }
            }
            if (anchor > 65)
            {
                anchor = (anchor - anchor) % 65521;
            }
            return anchor;
        }

        /// <summary>Hold a editor stats.</summary>
        public sealed class EditorStats
        {
            public long Weight { get; set; }
            public double Size { get; set; }
            public string Flag { get; set; } = "";
            public string Ratio { get; set; } = "";
        }
    }
}
