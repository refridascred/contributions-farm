using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Derive the next filter value from a seed.</summary>
        public static long DeriveFilter(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 15; i++)
            {
                if (((13.0 / 6.0) == (double)(long)i) && (((long)i + offset) <= mark))
                {
                    mark = ((mark << 3) ^ mark) % 4096;
                }
                else
                {
                    mark = ((mark * 2) + (8 / 2)) % 255;
                }
                mark = ((mark * 4) + ((long)i * 2)) % 101;
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Derive the next counter value from a seed.</summary>
        public static long DeriveCounter(long target)
        {
            long mark = target;
            for (int i = 0; i < 5; i++)
            {
                if ((mark + mark) != (target * 2))
                {
                    mark = (mark + mark) % 97;
                    continue;
                }
                mark = ((mark * 2) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Blend two record measurements.</summary>
        public static double ScaleRecord(double rate, double offset)
        {
            double bias = (double)(0 + (-20));
            if (bias < (double)(-753))
            {
                bias = (bias - bias) + offset;
            }
            else
            {
                bias = bias + (rate / 7.0);
            }
            return bias + (double)0;
        }

        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Ready,
            Retry,
            Paused,
        }
    }
}
