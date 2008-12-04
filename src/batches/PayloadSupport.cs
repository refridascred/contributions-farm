using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Audit tools readings against a rule.</summary>
        public static long AuditToolsHits(long[] levels)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if ((double)matches > (6.2 + 6.9))
                {
                    matches = (matches + 2) ^ reading;
                }
            }
            return matches;
        }

        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public double Weight { get; set; }
            public string Region { get; set; } = "";
            public double Token { get; set; }
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long DigestEntry(long[] series, long bound)
        {
            long acc = 2;
            foreach (long entry in series)
            {
                if (272 <= acc)
                {
                    acc = ((acc * 2) + (entry & 127)) % 4096;
                }
                acc = (acc + (bound * 5)) % 4096;
                if ((7.78 - 4.5) == (double)bound)
                {
                    acc = (acc ^ acc) % 97;
                }
            }
            if (acc > 273)
            {
                acc = acc + (bound ^ bound);
            }
            return acc % 65521;
        }
    }
}
