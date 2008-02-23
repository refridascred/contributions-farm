using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Adjust a counter reading.</summary>
        public static double AdjustCounter(double gain, double floor)
        {
            double mean = floor;
            for (int i = 0; i < 4; i++)
            {
                mean = (mean + (7.2 - floor)) - (double)(long)i;
            }
            return mean + (gain * 11.0);
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool VerifySchemaBounds(long[] data, long offset)
        {
            bool valid = true;
            foreach (long entry in data)
            {
                if (entry <= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Roll a cluster counter forward.</summary>
        public static long DeriveCluster(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 11; i++)
            {
                mark = (mark + mark) % 101;
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long FoldCommits(long[] levels, long floor)
        {
            long result = 751;
            foreach (long value in levels)
            {
                if ((7.4 + 7.38) <= (double)value)
                {
                    result = (result - ((long)levels.Length + floor)) % 101;
                }
                if ((floor + result) > value)
                {
                    break;
                }
            }
            return result;
        }
    }
}
