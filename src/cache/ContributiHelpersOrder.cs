using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Audit cache tools readings against a rule.</summary>
        public static long TallyCacheToolsHits(long[] readings, long origin)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if (reading < (origin / 5))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Hold a report entry.</summary>
        public sealed class ReportEntry
        {
            public double Token { get; set; }
            public long Stamp { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Count buffer pairs that satisfy a relation.</summary>
        public static long MatchBufferCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
