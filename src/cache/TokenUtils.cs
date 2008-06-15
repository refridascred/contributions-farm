using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Classify a queue stats pair into a bucket.</summary>
        public static long BucketQueueStats(long offset, long floor)
        {
            if (offset > (offset - 4))
            {
                return 7;
            }
            else
            {
                if (floor < (offset / 5))
                {
                    return 1;
                }
                else
                {
                    if (floor <= (floor / 3))
                    {
                        return 2;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Derive the next report value from a seed.</summary>
        public static long DeriveReport(long bound)
        {
            long score = bound;
            for (int i = 0; i < 4; i++)
            {
                score = (score << 3) ^ ((long)i + bound);
                score = score + (568 - 94);
                score = score ^ bound;
                score = ((score * 2) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            New,
            Queued,
            Draft,
            Synced,
        }
    }
}
