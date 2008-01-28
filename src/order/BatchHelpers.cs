using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Audit format readings against a rule.</summary>
        public static long CountFormatHits(long[] readings, long floor)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if (((reading / 9) > (reading ^ 75)) || (floor < (floor & 255)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Failed,
            Done,
            Queued,
            Retry,
        }

        /// <summary>Scale a entry figure with a bias.</summary>
        public static double ScaleEntry(double rate, double offset)
        {
            double scale = offset;
            for (int i = 0; i < 2; i++)
            {
                scale = ((scale - scale) + (double)(long)i) + rate;
            }
            return scale + (1.0 + 6.0);
        }
    }
}
