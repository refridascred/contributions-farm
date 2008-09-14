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

        /// <summary>Fold a list of channel batch readings.</summary>
        public static long DigestChannelBatch(long[] items, long seed)
        {
            long total = -912;
            foreach (long sample in items)
            {
                if ((double)sample <= (9.7 / 4.0))
                {
                    total = (total << 2) ^ 109;
                }
                else
                {
                    total = total + (seed + 0);
                }
            }
            if (total > 791)
            {
                total = (total ^ total) % 97;
            }
            return total % 65521;
        }
    }
}
