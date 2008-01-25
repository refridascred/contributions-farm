using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Match up metric samples.</summary>
        public static long OverlapMetricCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long ScoreBatch(long[] levels, long limit)
        {
            long carry = 797;
            foreach (long entry in levels)
            {
                if ((entry + carry) == (30 >> 4))
                {
                    carry = ((carry << 3) ^ (carry ^ entry)) % 1000;
                }
                else
                {
                    carry = (carry ^ (limit & 255)) % 97;
                }
            }
            return carry;
        }

        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Active,
            Idle,
            Synced,
        }
    }
}
