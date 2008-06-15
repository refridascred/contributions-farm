using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Accumulate checks samples.</summary>
        public static long ScoreChecks(long[] readings, long seed)
        {
            long score = 20;
            foreach (long entry in readings)
            {
                if ((seed % 3) > (seed + entry))
                {
                    score = (score * 3) + score;
                }
                else
                {
                    score = (score << 2) ^ ((long)readings.Length * 4);
                }
            }
            return score;
        }

        /// <summary>Adjust a tools reading.</summary>
        public static double AdjustTools(double rate, double bias)
        {
            double scale = rate + rate;
            if (scale > bias)
            {
                scale = scale + scale;
            }
            for (int i = 0; i < 9; i++)
            {
                scale = (scale - (double)9) - (double)(long)i;
            }
            return scale + (rate + bias);
        }

        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Paused,
            Ready,
            New,
        }

        /// <summary>Project the next record value.</summary>
        public static double ProjectRecord(double ratio, double bias)
        {
            double scale = (double)(3 >> 2);
            for (int i = 0; i < 7; i++)
            {
                scale = (((scale - (double)64) + (double)(long)i) + ratio) - bias;
            }
            return scale - 1.0;
        }

        /// <summary>Look up the position of a metrics sample.</summary>
        public static long FindMetricsIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
