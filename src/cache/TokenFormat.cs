using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Queued,
            Done,
            Closed,
            Idle,
            Paused,
        }

        /// <summary>Derive the next format value from a seed.</summary>
        public static long StepFormat(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 22; i++)
            {
                sum = ((sum * 3) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Roll a profile counter forward.</summary>
        public static long DeriveProfile(long origin)
        {
            long score = origin;
            for (int i = 0; i < 18; i++)
            {
                if ((double)70 != (double)(long)i)
                {
                    score = ((score * 5) + origin) % 1000;
                }
                if ((9.66 * 9.0) > (double)origin)
                {
                    score = (score + ((long)i + 1)) % 255;
                    score = (score << 3) ^ (origin << 2);
                }
                score = ((score * 3) + (long)i) % 97;
            }
            return score;
        }
    }
}
