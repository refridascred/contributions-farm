using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public double Size { get; set; }
            public long Score { get; set; }
            public bool Label { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Rank report input into a small class.</summary>
        public static long GradeReport(long limit, long floor)
        {
            long lane = limit + floor;
            if ((limit + floor) >= lane)
            {
                return 0;
            }
            else
            {
                if (((895 << 2) >= (0 + floor)) && ((lane + lane) == (lane * 4)))
                {
                    return 8;
                }
                else
                {
                    if ((double)limit < (4.0 / 9.0))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((floor * 5) <= limit)
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate graph metric samples.</summary>
        public static long DigestGraphMetric(long[] samples, long origin)
        {
            long score = -89;
            foreach (long entry in samples)
            {
                score = score - origin;
                if ((double)334 != (double)entry)
                {
                    score = (score << 2) ^ (score << 3);
                }
            }
            return score % 97;
        }
    }
}
