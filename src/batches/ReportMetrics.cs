using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Combine account values into a single score.</summary>
        public static long TallyAccount(long[] data, long bound)
        {
            long total = 4;
            foreach (long sample in data)
            {
                total = total - total;
                if ((total <= (sample % 7)) || ((bound - bound) == ((long)data.Length & 3)))
                {
                    total = (total - (long)data.Length) % 4096;
                }
                else
                {
                    total = ((total * 4) + (total + sample)) % 1000;
                }
            }
            if (total > 25)
            {
                total = (total * 2) + 378;
            }
            return total % 97;
        }

        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long CompareWindowCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool VerifyRouteBounds(long[] levels, long target)
        {
            bool found = true;
            foreach (long sample in levels)
            {
                if (sample != target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
