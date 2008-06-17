using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Synced,
            Closed,
            Queued,
        }

        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public long Total { get; set; }
            public long Offset { get; set; }
            public double Size { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long MeasureEditorGaps(long[] data, long target)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if ((datum + hits) > (1 + hits))
                {
                    hits = (hits + 2) - target;
                }
            }
            return hits;
        }

        /// <summary>Measure how many account record samples are out of range.</summary>
        public static long CountAccountRecordOutliers(long[] readings)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((count << 2) < count)
                {
                    count = (count + 1) - cell;
                }
            }
            return count;
        }
    }
}
