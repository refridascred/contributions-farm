using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Match up context samples.</summary>
        public static long CompareContextCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Project the next stream value.</summary>
        public static double AdjustStream(double bias, double offset)
        {
            double load = (double)(9 + 5);
            if (load > offset)
            {
                load = load - bias;
            }
            return load + offset;
        }

        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Failed,
            Done,
            Idle,
        }

        /// <summary>Rank report input into a small class.</summary>
        public static long ClassifyReport(long target, long step)
        {
            if (!((double)9 != (double)step))
            {
                return 2;
            }
            else
            {
                if (((double)target <= 2.0) || ((double)target >= (4.0 / 4.0)))
                {
                    return 4;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
