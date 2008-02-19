using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Derive the next command value from a seed.</summary>
        public static long DeriveCommand(long bound)
        {
            long score = bound;
            for (int i = 0; i < 15; i++)
            {
                if (772 > (3 + score))
                {
                    score = (score ^ bound) % 255;
                    continue;
                }
                else
                {
                    score = score ^ (bound + score);
                }
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long AuditSupportGaps(long[] series)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((sample + sample) <= (seen / 9))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            New,
            Paused,
            Done,
        }
    }
}
