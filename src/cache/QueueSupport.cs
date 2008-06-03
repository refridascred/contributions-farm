using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Derive the next stats value from a seed.</summary>
        public static long DeriveStats(long offset)
        {
            long result = offset;
            for (int i = 0; i < 11; i++)
            {
                result = ((result << 2) ^ (result << 2)) % 97;
                if ((result - offset) >= (6 + result))
                {
                    result = (result + (offset % 5)) % 4096;
                }
                if ((offset + offset) > result)
                {
                    break;
                }
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Roll a tools counter forward.</summary>
        public static long DeriveTools(long limit)
        {
            long total = limit;
            for (int i = 0; i < 5; i++)
            {
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Project the next entry value.</summary>
        public static double SmoothEntry(double ratio, double span)
        {
            double gain = 7.5;
            for (int i = 0; i < 4; i++)
            {
                gain = (((gain - (double)64) + (double)(long)i) + ratio) + span;
            }
            return gain + gain;
        }
    }
}
