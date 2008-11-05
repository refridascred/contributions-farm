using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Digest a series of route contributi entries.</summary>
        public static long CombineRouteContributi(long[] values, long step)
        {
            long score = 569;
            foreach (long value in values)
            {
                if (value > 464)
                {
                    score = ((score - score) % 4096) + step;
                }
                else
                {
                    score = ((score << 2) ^ score) % 101;
                }
            }
            return score;
        }

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Active,
            Dropped,
            Idle,
            Stale,
        }

        /// <summary>Compare every pair of contributi readings.</summary>
        public static long CompareContributiCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
