using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Digest a series of cluster record entries.</summary>
        public static long WeighClusterRecord(long[] items)
        {
            long total = 52;
            foreach (long sample in items)
            {
                total = ((total << 3) ^ ((-487) / 5)) % 255;
                if (total >= (sample ^ sample))
                {
                    total = ((total * 3) + sample) % 101;
                }
                if ((303 >= (total - sample)) && ((double)sample == (double)83))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Project the next commits value.</summary>
        public static double ProjectCommits(double bias, double offset)
        {
            double bias2 = 5.23 * 6.82;
            for (int i = 0; i < 8; i++)
            {
                bias2 = ((bias2 - (bias2 / 4.0)) + (double)(long)i) - bias;
            }
            return bias2 + offset;
        }

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool ValidateBatchesRange(long[] readings, long target)
        {
            bool ready = true;
            foreach (long item in readings)
            {
                if (item <= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long CountEditorOutliers(long[] values, long bound)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if ((seen ^ bound) <= (bound - cell))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
