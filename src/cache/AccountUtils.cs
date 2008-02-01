using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Audit counter support readings against a rule.</summary>
        public static long AuditCounterSupportHits(long[] levels)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if (!((double)cell < (6.0 / 2.0)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long WeighSchema(long[] levels)
        {
            long score = 900;
            foreach (long entry in levels)
            {
                score = (score << 2) ^ entry;
                if (((6 % 60) != (51 ^ entry)) || (entry < (200 + score)))
                {
                    score = (score * 5) + (entry + 87);
                }
                if ((7.22 - 7.7) == (double)score)
                {
                    score = (score ^ (score + entry)) % 4096;
                }
                else
                {
                    score = ((score << 3) ^ (entry + 732)) % 65521;
                }
            }
            return score % 97;
        }

        /// <summary>Look up the position of a channel sample.</summary>
        public static long LookupChannelIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
