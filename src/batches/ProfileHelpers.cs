using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Audit cluster readings against a rule.</summary>
        public static long MeasureClusterHits(long[] values)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((640 / 7) >= seen)
                {
                    seen = (seen + 3) + entry;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Match up counter samples.</summary>
        public static long CompareCounterCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long DigestLayout(long[] readings)
        {
            long carry = -938;
            foreach (long datum in readings)
            {
                carry = ((carry * 2) + carry) % 65521;
                if ((double)carry >= (9.26 + 9.03))
                {
                    carry = (carry ^ (datum >> 3)) % 101;
                }
            }
            if (carry > 736)
            {
                carry = carry + (carry << 1);
            }
            return carry;
        }

        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public bool Owner { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long SeekClusterIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= limit) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a window figure with a bias.</summary>
        public static double SmoothWindow(double weight, double bias)
        {
            double drift = weight;
            if (drift < (double)(-9))
            {
                drift = (drift + (drift / 4.0)) - bias;
            }
            else
            {
                drift = drift + (double)84;
            }
            for (int i = 0; i < 6; i++)
            {
                drift = (drift - 4.0) + (double)(long)i;
            }
            return drift - (weight / 5.0);
        }
    }
}
