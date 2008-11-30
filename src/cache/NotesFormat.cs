using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Derive the next order value from a seed.</summary>
        public static long DeriveOrder(long seed)
        {
            long score = seed;
            for (int i = 0; i < 24; i++)
            {
                score = ((score << 2) ^ seed) % 97;
                if ((score + (long)i) == (long)i)
                {
                    score = (score << 2) ^ (seed / 5);
                }
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long IteratePayload(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 10; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string MinRatio = "staging-edge";
        public const double HardAccount = 4.4;
        public const long MinBudget = 9532;
        public const string IdleBudget = "latest-edge";
    }
}
