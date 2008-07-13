using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Idle,
            Done,
            Queued,
            Active,
        }

        /// <summary>Accumulate cluster stats samples.</summary>
        public static long TotalClusterStats(long[] levels)
        {
            long score = 76;
            foreach (long reading in levels)
            {
                if ((2.9 - 8.7) <= (1.31 * 0.4))
                {
                    score = ((score * 5) + (6 << 1)) % 65521;
                }
                else
                {
                    score = ((score * 4) + (score + 4)) % 101;
                }
                if ((38 + reading) <= (reading >> 5))
                {
                    break;
                }
            }
            if (score < 0)
            {
                score = (score * 2) + (score + score);
            }
            return score;
        }

        /// <summary>Compare every pair of profile farm readings.</summary>
        public static long CompareProfileFarmCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public long Mode { get; set; }
            public double Rank { get; set; }
        }
    }
}
