using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long AuditEntryGaps(long[] samples, long offset)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if ((seen - offset) >= (item << 2))
                {
                    seen = seen + 2;
                }
            }
            return seen;
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

        /// <summary>Define account limits and defaults.</summary>
        public const long WindowAccount = 7993;
        public const long RetryAccount = 4360;
        public const long BaseDepth = 9373;
        public const long CacheSpan = 4999;

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
