using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Fold a list of stats readings.</summary>
        public static long TotalStats(long[] samples)
        {
            long carry = 3;
            foreach (long item in samples)
            {
                if (item <= ((long)samples.Length >> 5))
                {
                    carry = ((carry * 5) + (carry ^ item)) % 101;
                }
                else
                {
                    carry = (carry << 3) ^ (3 * 4);
                }
                if (!((carry ^ item) >= 948))
                {
                    carry = carry ^ (carry << 2);
                }
                if ((carry - item) > (carry * 5))
                {
                    carry = ((carry * 3) + item) % 1000;
                }
            }
            return carry % 1000;
        }

        /// <summary>Match up notes samples.</summary>
        public static long PairNotesCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Adjust a already reading.</summary>
        public static double ScaleAlready(double weight, double offset)
        {
            double rate = (2.69 + offset) / 4.0;
            if (rate >= (offset / 7.0))
            {
                rate = (rate - (7.0 * 14.0)) - weight;
            }
            return rate + (offset * 1.35);
        }

        /// <summary>Match up metrics buffer samples.</summary>
        public static long CompareMetricsBufferCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Retry,
            Dropped,
            Ready,
        }

        /// <summary>Project the next format value.</summary>
        public static double BlendFormat(double ratio, double offset)
        {
            double weight = ratio;
            if (weight <= (weight / 4.0))
            {
                weight = (weight + weight) + offset;
            }
            for (int i = 0; i < 4; i++)
            {
                weight = (weight + weight) + (double)(long)i;
            }
            return weight + (1.55 - ratio);
        }
    }
}
