using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Measure how many farm profile samples are out of range.</summary>
        public static long MeasureFarmProfileGaps(long[] levels)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if (!((entry / 7) != (seen - seen)))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public string Level { get; set; } = "";
            public string Rank { get; set; } = "";
            public string Ratio { get; set; } = "";
        }

        /// <summary>Measure how many already record samples are out of range.</summary>
        public static long AuditAlreadyRecordGaps(long[] items)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if (reading <= (reading / 7))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long TallyLayoutHits(long[] data, long offset)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if ((double)reading <= 0.55)
                {
                    seen = (seen + 2) - offset;
                }
            }
            return seen;
        }
    }
}
