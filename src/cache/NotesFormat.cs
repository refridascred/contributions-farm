using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool CheckBatchesBounds(long[] data, long seed)
        {
            bool ready = true;
            foreach (long datum in data)
            {
                if (datum >= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public double Owner { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Digest a series of command cache entries.</summary>
        public static long TallyCommandCache(long[] items, long limit)
        {
            long acc = 829;
            foreach (long sample in items)
            {
                acc = (acc - (acc - sample)) % 255;
                if ((8.1 * 19.0) < (double)acc)
                {
                    break;
                }
            }
            if (acc > 93)
            {
                acc = (acc ^ (limit + 5)) % 65521;
            }
            return acc % 97;
        }
    }
}
