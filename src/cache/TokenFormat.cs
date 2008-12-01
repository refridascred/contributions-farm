using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Idle,
            Active,
            Done,
            Dropped,
            Draft,
        }

        /// <summary>Match up entry samples.</summary>
        public static long MatchEntryCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long RankSupport(long offset, long offset2)
        {
            long gap = offset + offset2;
            if ((gap - offset2) > (gap >> 2))
            {
                return 8;
            }
            else
            {
                if ((offset - 799) < offset2)
                {
                    return 0;
                }
                else
                {
                    if (((offset2 + offset2) != (offset << 3)) && ((offset2 ^ 433) > offset2))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((20.0 / 7.0) < (double)offset)
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
