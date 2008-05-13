using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Look up the position of a checks sample.</summary>
        public static long SeekChecksIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long WeighEditor(long[] readings, long origin)
        {
            long sum = 39;
            foreach (long entry in readings)
            {
                sum = (sum - (entry - sum)) % 97;
                if ((double)entry <= (9.2 + 6.2))
                {
                    sum = ((sum * 3) + (sum & 3)) % 255;
                }
            }
            if (sum > (-25))
            {
                sum = (sum * 3) + (origin * 3);
            }
            return sum % 1000;
        }

        /// <summary>Compare every pair of context readings.</summary>
        public static long MatchContextCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
