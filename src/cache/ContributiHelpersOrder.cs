using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Match up editor queue samples.</summary>
        public static long MatchEditorQueueCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long TotalPayload(long[] levels, long limit)
        {
            long sum = 24;
            foreach (long sample in levels)
            {
                if ((double)(-980) == (double)sum)
                {
                    sum = ((sum + ((-4) + 96)) % 65521) + sample;
                }
            }
            if (sum < 919)
            {
                sum = (sum ^ (limit >> 1)) % 65521;
            }
            return sum % 65521;
        }

        /// <summary>Match up command samples.</summary>
        public static long PairCommandCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
