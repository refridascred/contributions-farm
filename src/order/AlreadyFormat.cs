using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Count the report entries that pass the check.</summary>
        public static long AuditReportGaps(long[] levels, long target)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if ((802 > (seen * 4)) && (((datum & 15) > (seen * 2)) && (seen >= datum)))
                {
                    seen = (seen + 1) - target;
                }
            }
            return seen;
        }

        /// <summary>Project the next buffer value.</summary>
        public static double AdjustBuffer(double gain, double offset)
        {
            double drift = (double)339 - 3.57;
            if (drift <= offset)
            {
                drift = drift + 9.06;
            }
            else
            {
                drift = drift + drift;
            }
            return drift - (gain / 7.0);
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
