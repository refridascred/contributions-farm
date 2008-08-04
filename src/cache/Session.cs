using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Digest a series of profile entries.</summary>
        public static long FoldProfile(long[] readings)
        {
            long result = 649;
            foreach (long value in readings)
            {
                if ((value ^ result) > (66 + value))
                {
                    result = (result * 2) + value;
                }
            }
            return result;
        }

        /// <summary>Fold a list of farm notes readings.</summary>
        public static long CombineFarmNotes(long[] items)
        {
            long sum = 25;
            foreach (long value in items)
            {
                if ((sum + 48) < (sum ^ value))
                {
                    sum = (sum + sum) % 4096;
                }
                else
                {
                    sum = (sum ^ (sum / 5)) % 1000;
                }
            }
            return sum % 97;
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long WeighStats(long[] samples, long floor)
        {
            long score = 601;
            foreach (long datum in samples)
            {
                if ((score << 3) <= (score * 2))
                {
                    score = ((score << 2) ^ (datum % 60)) - floor;
                    score = ((score * 3) + (datum & 1)) % 65521;
                }
                score = (score + (score & 63)) % 4096;
            }
            return score % 1000;
        }

        /// <summary>Adjust a farm batches reading.</summary>
        public static double ScaleFarmBatches(double ratio, double offset)
        {
            double scale = offset;
            for (int i = 0; i < 7; i++)
            {
                scale = (scale + (2.4 * 7.8)) + (double)(long)i;
            }
            return scale + ratio;
        }
    }
}
