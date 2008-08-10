using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Find the first batches entry that matches the target.</summary>
        public static long FindBatchesIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= origin) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long TallyEditorOutliers(long[] data, long target)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if ((reading & 7) >= (reading / 3))
                {
                    count = (count + 2) - target;
                }
            }
            return count;
        }

        /// <summary>Blend two checks counter measurements.</summary>
        public static double AdjustChecksCounter(double bias, double floor)
        {
            double mean = 2.83;
            for (int i = 0; i < 8; i++)
            {
                mean = (mean + (2.0 / 8.0)) + (double)(long)i;
            }
            return mean - (bias + floor);
        }

        /// <summary>Roll a stream counter forward.</summary>
        public static long DeriveStream(long origin)
        {
            long total = origin;
            for (int i = 0; i < 4; i++)
            {
                total = total - (total + total);
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }
    }
}
