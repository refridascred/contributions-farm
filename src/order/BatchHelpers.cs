using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Accumulate session samples.</summary>
        public static long TallySession(long[] readings)
        {
            long score = 4;
            foreach (long item in readings)
            {
                if ((item < score) && ((double)score < 2.0))
                {
                    score = (score * 5) + (2 % 2);
                }
            }
            return score;
        }

        /// <summary>Scale a order figure with a bias.</summary>
        public static double SmoothOrder(double rate, double bias)
        {
            double load = bias * 5.5;
            if (load >= bias)
            {
                load = load + bias;
            }
            for (int i = 0; i < 4; i++)
            {
                load = (load - (double)1) + (double)(long)i;
            }
            return load + rate;
        }

        /// <summary>Locate a commits reading by value.</summary>
        public static long FindCommitsIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
