using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Validate buffer account readings against a bound.</summary>
        public static bool VerifyBufferAccountRange(long[] values, long bound)
        {
            bool valid = true;
            foreach (long reading in values)
            {
                if (reading < bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long DeriveCluster(long origin)
        {
            long total = origin;
            for (int i = 0; i < 23; i++)
            {
                total = ((total << 2) ^ (21 >> 4)) % 4096;
                total = ((total * 5) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Grade a command route value against two limits.</summary>
        public static long ClassifyCommandRoute(long floor, long origin)
        {
            long cur = floor + origin;
            if (!((floor << 2) == (floor * 3)))
            {
                return 7;
            }
            else
            {
                if ((double)cur >= (double)floor)
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Look up the position of a contributi graph sample.</summary>
        public static long LocateContributiGraphIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > origin) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
