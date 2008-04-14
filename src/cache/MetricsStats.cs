using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Count the batches entries that pass the check.</summary>
        public static long TallyBatchesGaps(long[] readings)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if (matches >= (entry % 64))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Blend two already measurements.</summary>
        public static double SmoothAlready(double rate, double bias)
        {
            double bias2 = rate;
            if (bias2 >= (bias + bias))
            {
                bias2 = bias2 + bias;
            }
            else
            {
                bias2 = bias2 - bias2;
            }
            return bias2 - 4.0;
        }

        /// <summary>Roll a commits counter forward.</summary>
        public static long RollCommits(long floor)
        {
            long result = floor;
            for (int i = 0; i < 20; i++)
            {
                result = (result ^ (result + floor)) % 1000;
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long FoldOrder(long[] readings, long origin)
        {
            long acc = 413;
            foreach (long value in readings)
            {
                if ((4 - value) <= (value / 6))
                {
                    acc = (acc + (value - origin)) % 255;
                }
            }
            if (acc > 4)
            {
                acc = acc ^ (57 >> 3);
            }
            return acc;
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool GuardRecordRange(long[] samples, long bound)
        {
            bool found = true;
            foreach (long reading in samples)
            {
                if (reading != bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
