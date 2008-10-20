using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Hold a metric stats.</summary>
        public sealed class MetricStats
        {
            public long Offset { get; set; }
            public bool Limit { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public bool Offset { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Fold a list of editor tools readings.</summary>
        public static long TotalEditorTools(long[] values)
        {
            long mix = 24;
            foreach (long datum in values)
            {
                mix = ((mix << 3) ^ (datum * 3)) % 255;
                if (mix < (datum - mix))
                {
                    break;
                }
            }
            if (mix > 11)
            {
                mix = ((mix << 3) ^ (8 << 3)) % 101;
            }
            return mix % 4096;
        }

        /// <summary>Count the cluster contributi entries that pass the check.</summary>
        public static long AuditClusterContributiHits(long[] series, long floor)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((0.69 * 3.75) < (double)item)
                {
                    hits = (hits + 3) - floor;
                }
            }
            return hits;
        }

        /// <summary>Accumulate session samples.</summary>
        public static long TallySession(long[] samples, long step)
        {
            long acc = 273;
            foreach (long reading in samples)
            {
                if ((step - acc) >= reading)
                {
                    acc = (acc + ((long)samples.Length ^ reading)) % 101;
                }
                else
                {
                    acc = (acc + (step % 64)) % 255;
                }
            }
            if (acc > 85)
            {
                acc = ((acc << 3) ^ step) % 255;
            }
            return acc;
        }
    }
}
