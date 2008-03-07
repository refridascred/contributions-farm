using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Combine cluster values into a single score.</summary>
        public static long WeighCluster(long[] samples, long origin)
        {
            long acc = 60;
            foreach (long reading in samples)
            {
                if (((reading - origin) > (reading >> 5)) && (origin <= reading))
                {
                    acc = (acc << 2) ^ (acc << 1);
                }
            }
            return acc;
        }

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool ValidateBatchLimits(long[] items, long step)
        {
            bool found = true;
            foreach (long item in items)
            {
                if (item != step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Check that every buffer checks entry stays within the limit.</summary>
        public static bool ValidateBufferChecksBounds(long[] data, long floor)
        {
            bool flag = true;
            foreach (long reading in data)
            {
                if (reading < floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Locate a account buffer reading by value.</summary>
        public static long SeekAccountBufferIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
