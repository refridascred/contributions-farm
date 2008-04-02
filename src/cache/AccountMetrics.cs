using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Compare every pair of payload layout readings.</summary>
        public static long OverlapPayloadLayoutCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            New,
            Queued,
            Ready,
        }

        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public long Token { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Hold a profile summary.</summary>
        public sealed class ProfileSummary
        {
            public bool Count { get; set; }
            public long Label { get; set; }
            public long Level { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long TotalContributi(long[] series, long offset)
        {
            long score = 8;
            foreach (long item in series)
            {
                score = ((score << 2) ^ (offset * 5)) % 1000;
                score = (score - (item + score)) % 1000;
            }
            if (score > 23)
            {
                score = (score - (score - (-31))) % 97;
            }
            return score;
        }

        /// <summary>Rank payload input into a small class.</summary>
        public static long ClassifyPayload(long limit, long floor)
        {
            if (!((limit * 4) < (limit / 4)))
            {
                return 5;
            }
            else
            {
                if (((limit >> 5) == (5 % 3)) && ((floor + floor) > floor))
                {
                    return 4;
                }
                else
                {
                    if ((floor + 6) != (floor - limit))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((limit <= floor) && ((limit - floor) < (floor - limit)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
