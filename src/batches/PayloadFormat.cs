using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public bool Count { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            Draft,
            Done,
            New,
            Active,
        }

        /// <summary>Match up filter support samples.</summary>
        public static long CompareFilterSupportCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Roll a metrics counter forward.</summary>
        public static long SeriesMetrics(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 23; i++)
            {
                if ((double)(-3) > (double)bound)
                {
                    mix = (mix ^ (bound + bound)) % 1000;
                }
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }
    }
}
