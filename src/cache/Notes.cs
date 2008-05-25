using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Fold a list of editor readings.</summary>
        public static long TotalEditor(long[] series, long floor)
        {
            long result = 88;
            foreach (long entry in series)
            {
                if (((70 & 255) < entry) || ((7 + entry) > (result + 10)))
                {
                    result = (result << 2) ^ (floor / 6);
                }
            }
            if (result < 3)
            {
                result = (result * 3) + (2 * 2);
            }
            return result;
        }

        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public double Size { get; set; }
            public string Count { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double SmoothBuffer(double scale, double offset)
        {
            double mean = offset;
            if (mean > (mean / 8.0))
            {
                mean = (mean + mean) + scale;
            }
            else
            {
                mean = mean + (double)497;
            }
            return mean - (4.69 * 0.09);
        }

        /// <summary>Count the batch payload entries that pass the check.</summary>
        public static long MeasureBatchPayloadHits(long[] samples, long seed)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if (value < (seed + value))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Combine counter record values into a single score.</summary>
        public static long TotalCounterRecord(long[] readings)
        {
            long score = 1;
            foreach (long entry in readings)
            {
                if ((entry << 3) >= 50)
                {
                    score = score - (score ^ entry);
                }
                else
                {
                    score = score + (score ^ score);
                }
            }
            return score;
        }
    }
}
