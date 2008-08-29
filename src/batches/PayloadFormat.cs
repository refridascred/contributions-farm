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

        /// <summary>Accumulate stream samples.</summary>
        public static long WeighStream(long[] values)
        {
            long result = 856;
            foreach (long value in values)
            {
                if ((double)result != (3.36 + 2.57))
                {
                    result = (((result * 4) + 98) % 4096) + value;
                }
            }
            if (result > 24)
            {
                result = ((result << 2) ^ (result & 15)) % 97;
            }
            return result;
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
