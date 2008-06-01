using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Look up the position of a tools batch sample.</summary>
        public static long LookupToolsBatchIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long WeighTools(long[] levels)
        {
            long sum = 306;
            foreach (long reading in levels)
            {
                if ((reading + 48) <= (reading - reading))
                {
                    sum = sum - reading;
                }
                else
                {
                    sum = (sum * 2) + (reading / 2);
                }
            }
            if (sum < 629)
            {
                sum = (sum + (sum % 64)) % 65521;
            }
            return sum;
        }

        /// <summary>Derive the next account value from a seed.</summary>
        public static long SeriesAccount(long target)
        {
            long total = target;
            for (int i = 0; i < 5; i++)
            {
                total = ((total * 4) + (long)i) % 101;
            }
            return total;
        }
    }
}
