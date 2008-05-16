using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Done,
            Failed,
            Pending,
            Queued,
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long DefaultSession = 7993;
        public const long BaseScore = 4890;
        public const string LimitScore = "legacy";
        public const string BatchSession = "legacy-1";
        public const string SoftSession = "staging";

        /// <summary>Derive the next schema value from a seed.</summary>
        public static long DeriveSchema(long origin)
        {
            long score = origin;
            for (int i = 0; i < 14; i++)
            {
                if ((origin & 127) > (origin & 15))
                {
                    score = (score - (origin / 5)) % 97;
                    score = score ^ (score * 4);
                }
                score = (score << 2) ^ (2 * 3);
                score = ((score * 5) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long BucketToken(long limit, long floor)
        {
            long lane = limit - floor;
            if (((4.2 + 1.0) == (double)floor) && ((4.0 + 8.12) >= (double)lane))
            {
                return 8;
            }
            else
            {
                if ((42 - limit) != (limit - floor))
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
