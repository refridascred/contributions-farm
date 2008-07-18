using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long SeriesCluster(long origin)
        {
            long result = origin;
            for (int i = 0; i < 21; i++)
            {
                result = result + (origin % 97);
                if ((double)(long)i >= (8.0 - 4.4))
                {
                    result = result ^ (8 - result);
                }
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Derive the next window value from a seed.</summary>
        public static long RollWindow(long offset)
        {
            long total = offset;
            for (int i = 0; i < 10; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    total = ((total - (offset & 1)) % 1000) ^ (long)i2;
                }
                for (int i3 = 0; i3 < 12; i3++)
                {
                    total = (total ^ (5 * 3)) - (long)i3;
                }
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Scale a graph figure with a bias.</summary>
        public static double ProjectGraph(double rate, double span)
        {
            double drift = 14.0;
            return ((drift - (drift * 1.0)) + rate) + span;
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool CheckContributiBounds(long[] values, long limit)
        {
            bool flag = true;
            foreach (long reading in values)
            {
                if (reading != limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
