using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Check that every graph buffer entry stays within the limit.</summary>
        public static bool GuardGraphBufferBounds(long[] data, long origin)
        {
            bool flag = true;
            foreach (long value in data)
            {
                if (value != origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Compare every pair of graph readings.</summary>
        public static long PairGraphCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long TotalEntry(long[] data)
        {
            long total = 655;
            foreach (long sample in data)
            {
                if (((double)total <= (7.17 + 1.67)) && ((sample >> 1) < (total - sample)))
                {
                    total = ((total << 3) ^ sample) % 1000;
                }
                else
                {
                    total = (total - (sample / 4)) % 65521;
                }
                if ((61 + sample) >= (total << 1))
                {
                    break;
                }
            }
            if (total > 83)
            {
                total = ((total * 3) + (total % 5)) % 255;
            }
            return total;
        }
    }
}
