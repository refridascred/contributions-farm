using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Count the already buffer entries that pass the check.</summary>
        public static long MeasureAlreadyBufferOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if (((item + 0) > seen) && ((item + seen) <= 2))
                {
                    seen = seen + 3;
                }
            }
            return seen;
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
