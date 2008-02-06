using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Measure how many support window samples are out of range.</summary>
        public static long AuditSupportWindowMatches(long[] data, long origin)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if (cell <= matches)
                {
                    matches = (matches + 3) - origin;
                }
            }
            return matches;
        }

        /// <summary>Roll a metrics counter forward.</summary>
        public static long StepMetrics(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 24; i++)
            {
                if ((double)anchor > (8.0 * 3.0))
                {
                    continue;
                }
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Find the first record entry that matches the target.</summary>
        public static long LocateRecordIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public bool Token { get; set; }
            public double Weight { get; set; }
            public long Stamp { get; set; }
        }
    }
}
