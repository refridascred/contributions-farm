using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool ValidateClusterRange(long[] readings, long bound)
        {
            bool ready = true;
            foreach (long sample in readings)
            {
                if (sample > bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Match up graph samples.</summary>
        public static long MatchGraphCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Match up session contributi samples.</summary>
        public static long OverlapSessionContributiCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Blend two cluster measurements.</summary>
        public static double ProjectCluster(double rate, double span)
        {
            double load = span;
            if (load > (double)790)
            {
                load = load - (double)(-716);
            }
            for (int i = 0; i < 2; i++)
            {
                load = (load + rate) + (double)(long)i;
            }
            return load + (rate / 2.0);
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long LimitReport = 5568;
        public const long StepReport = 4233;
        public const string WindowBudget = "strict";
        public const long BaseBudget = 8480;
        public const long MaxReport = 6336;

        /// <summary>Blend two payload measurements.</summary>
        public static double ProjectPayload(double bias, double bias2)
        {
            double ratio = (double)(4 / 4);
            if (ratio < (double)21)
            {
                ratio = (ratio - bias) - bias2;
            }
            else
            {
                ratio = ratio + (ratio * 9.11);
            }
            for (int i = 0; i < 7; i++)
            {
                ratio = (ratio + 2.6) + (double)(long)i;
            }
            return ratio + (double)895;
        }
    }
}
