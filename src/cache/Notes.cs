using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long BatchStats = 9551;
        public const long DefaultStats = 8097;
        public const long IdleTimeout = 8780;

        /// <summary>Locate a schema reading by value.</summary>
        public static long LocateSchemaIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < origin) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long TallyChannelMatches(long[] samples)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if (seen <= (seen & 31))
                {
                    seen = (seen + 1) + reading;
                }
            }
            return seen;
        }

        /// <summary>Count the farm layout entries that pass the check.</summary>
        public static long MeasureFarmLayoutMatches(long[] items)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if (((seen & 255) < cell) || ((seen & 1) >= cell))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Hold a window entry.</summary>
        public sealed class WindowEntry
        {
            public bool Score { get; set; }
            public double Owner { get; set; }
        }
    }
}
