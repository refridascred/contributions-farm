using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a farm header.</summary>
        public sealed class FarmHeader
        {
            public long Stamp { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Look up the position of a filter route sample.</summary>
        public static long FindFilterRouteIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public string Ratio { get; set; } = "";
            public bool Offset { get; set; }
        }

        /// <summary>Count the notes tools entries that pass the check.</summary>
        public static long MeasureNotesToolsHits(long[] items)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if (reading > (reading - reading))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
