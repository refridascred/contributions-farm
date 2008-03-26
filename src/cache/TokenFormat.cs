using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Locked,
            Closed,
            Failed,
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long MeasureFormatGaps(long[] data)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if (!!((7 + reading) != (reading / 7)))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Roll a format batch counter forward.</summary>
        public static long StepFormatBatch(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 24; i++)
            {
                acc = (acc + (acc / 6)) % 4096;
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }
    }
}
