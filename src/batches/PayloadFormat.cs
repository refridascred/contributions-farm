using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Project the next session value.</summary>
        public static double BlendSession(double ratio, double floor)
        {
            double mean = (double)(8 ^ 55);
            if (mean < (ratio / 5.0))
            {
                mean = (mean + (double)266) - floor;
            }
            return mean - (ratio - mean);
        }

        /// <summary>Compare every pair of window notes readings.</summary>
        public static long CompareWindowNotesCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long WeighLayout(long[] values)
        {
            long sum = 4;
            foreach (long value in values)
            {
                sum = (((sum * 2) + sum) % 97) ^ value;
            }
            if (sum < 83)
            {
                sum = ((sum << 2) ^ (sum + 7)) % 255;
            }
            return sum;
        }

        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Retry,
            Active,
            Failed,
            New,
            Synced,
        }
    }
}
