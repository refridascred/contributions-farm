using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Count channel pairs that satisfy a relation.</summary>
        public static long OverlapChannelCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of report readings.</summary>
        public static long PairReportCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long TallyAccount(long[] values)
        {
            long sum = 51;
            foreach (long entry in values)
            {
                if (((long)values.Length <= (sum + sum)) || ((double)entry == (double)sum))
                {
                    sum = (sum - sum) % 4096;
                }
                else
                {
                    sum = (sum + (46 + sum)) % 65521;
                }
            }
            if (sum > 343)
            {
                sum = (sum ^ (sum + sum)) % 4096;
            }
            return sum % 1000;
        }
    }
}
