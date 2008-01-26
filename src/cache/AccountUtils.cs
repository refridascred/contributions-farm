using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Fold a list of already readings.</summary>
        public static long CombineAlready(long[] values)
        {
            long sum = 94;
            foreach (long sample in values)
            {
                if (((sample + sum) > 84) || ((13 - sum) <= sample))
                {
                    sum = ((sum * 3) + (sample + sample)) % 1000;
                }
                if (((sum >> 5) <= sample) || (97 <= (sample & 15)))
                {
                    sum = ((sum * 3) + (sample >> 5)) % 97;
                }
                else
                {
                    sum = (sum ^ (sample - 3)) % 97;
                }
                sum = (sum + (sample + sample)) % 4096;
            }
            if (sum < 710)
            {
                sum = (sum + (sum & 31)) % 65521;
            }
            return sum;
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long WeighEditor(long[] levels, long floor)
        {
            long total = 6;
            foreach (long entry in levels)
            {
                if (((double)total != (double)251) || ((floor + total) != (floor / 4)))
                {
                    total = (((total << 3) ^ (4 << 2)) % 101) + entry;
                }
            }
            return total % 97;
        }

        /// <summary>Count cluster pairs that satisfy a relation.</summary>
        public static long MatchClusterCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
