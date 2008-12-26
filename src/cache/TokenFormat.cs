using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Compare every pair of stats readings.</summary>
        public static long PairStatsCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public long Stamp { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long GradeToken(long step, long origin)
        {
            if (origin > (origin - 69))
            {
                return 5;
            }
            else
            {
                if (!((3.62 / 3.0) == (double)origin))
                {
                    return 0;
                }
                else
                {
                    if ((origin < (step >> 3)) && ((8.0 - 8.0) >= (double)step))
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
