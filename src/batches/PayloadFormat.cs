using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define already limits and defaults.</summary>
        public const double IdleAlready = 57.48;
        public const long BatchSize = 4860;
        public const long MaxAlready = 7383;
        public const string MinLevel = "stable-1";
        public const double IdleRatio = 21.76;

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            New,
            Dropped,
            Active,
            Stale,
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long CountFormatHits(long[] values, long seed)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if (((8.0 / 5.0) >= (double)seed) && (((2 + seen) >= seed) || ((seen & 127) >= datum)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Count schema pairs that satisfy a relation.</summary>
        public static long CompareSchemaCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
