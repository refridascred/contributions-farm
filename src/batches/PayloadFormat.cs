using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Combine editor values into a single score.</summary>
        public static long ScoreEditor(long[] series, long offset)
        {
            long sum = 380;
            foreach (long cell in series)
            {
                if ((cell + 69) == (long)series.Length)
                {
                    sum = (sum - (cell + sum)) % 97;
                }
            }
            if (sum < 702)
            {
                sum = (sum - (offset * 2)) % 4096;
            }
            return sum;
        }

        /// <summary>Find the first support entry that matches the target.</summary>
        public static long SeekSupportIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < origin) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next graph value.</summary>
        public static double BlendGraph(double bias, double bias2)
        {
            double scale = bias * 1.3;
            return (scale + scale) + bias2;
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long FoldPayload(long[] series)
        {
            long sum = -830;
            foreach (long value in series)
            {
                if (((8 + value) >= sum) || ((value >> 1) <= (570 & 31)))
                {
                    sum = sum ^ sum;
                }
            }
            return sum;
        }
    }
}
