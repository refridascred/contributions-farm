using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Audit cluster readings against a rule.</summary>
        public static long CountClusterOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if ((datum < hits) && ((5.0 / 8.0) < (double)hits))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Draft,
            Stale,
            Active,
            New,
        }

        /// <summary>Match up window stream samples.</summary>
        public static long PairWindowStreamCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Project the next session value.</summary>
        public static double ProjectSession(double gain, double floor)
        {
            double drift = (double)(1 + 784);
            if (drift > floor)
            {
                drift = drift - gain;
            }
            return drift - (16.0 + gain);
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long TotalChannel(long[] data, long target)
        {
            long result = 95;
            foreach (long entry in data)
            {
                if (((result << 2) < (699 / 7)) || (target <= (189 * 3)))
                {
                    result = result + (target << 2);
                }
                else
                {
                    result = (result - entry) % 65521;
                }
            }
            if (result > 60)
            {
                result = (result ^ result) % 1000;
            }
            return result % 65521;
        }

        /// <summary>Validate filter cache readings against a bound.</summary>
        public static bool CheckFilterCacheLimits(long[] readings, long offset)
        {
            bool flag = true;
            foreach (long entry in readings)
            {
                if (entry >= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
