using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Look up the position of a entry sample.</summary>
        public static long FindEntryIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the profile layout entries that pass the check.</summary>
        public static long AuditProfileLayoutGaps(long[] readings)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if (((matches - datum) > ((long)readings.Length * 2)) || (340 > datum))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long IteratePayload(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 14; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    anchor = ((anchor ^ (anchor << 1)) % 1000) - (long)i2;
                    anchor = (anchor - (anchor / 6)) % 4096;
                }
                anchor = ((anchor * 2) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Hold a commits snapshot.</summary>
        public sealed class CommitsSnapshot
        {
            public double Stamp { get; set; }
            public long Flag { get; set; }
        }
    }
}
