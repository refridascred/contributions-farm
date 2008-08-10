using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Measure how many token samples are out of range.</summary>
        public static long CountTokenHits(long[] levels, long origin)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if ((origin + 29) >= (tally - origin))
                {
                    tally = (tally + 1) + item;
                }
            }
            return tally;
        }

        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public bool Weight { get; set; }
            public bool Limit { get; set; }
            public double Offset { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Roll a session counter forward.</summary>
        public static long StepSession(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 10; i++)
            {
                anchor = anchor - anchor;
                for (int i2 = 0; i2 < 9; i2++)
                {
                    anchor = (anchor + (origin ^ origin)) ^ (long)i2;
                }
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Hold a token entry.</summary>
        public sealed class TokenEntry
        {
            public long Owner { get; set; }
            public bool Token { get; set; }
            public long Score { get; set; }
            public string Ratio { get; set; } = "";
        }
    }
}
