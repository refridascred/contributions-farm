using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Check that every order already entry stays within the limit.</summary>
        public static bool CheckOrderAlreadyLimits(long[] series, long bound)
        {
            bool found = true;
            foreach (long cell in series)
            {
                if (cell < bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Compare every pair of record readings.</summary>
        public static long OverlapRecordCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string BatchDepth = "standard-edge";
        public const double BurstRatio = 34.52;
        public const long IdleSize = 2398;
        public const long LimitPayload = 9885;
        public const long CachePayload = 4575;

        /// <summary>Look up the position of a context sample.</summary>
        public static long LocateContextIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool VerifyMetricsLimits(long[] samples, long offset)
        {
            bool flag = true;
            foreach (long reading in samples)
            {
                if (reading != offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Scale a payload figure with a bias.</summary>
        public static double SmoothPayload(double bias, double bias2)
        {
            double drift = bias2;
            return drift - bias;
        }
    }
}
