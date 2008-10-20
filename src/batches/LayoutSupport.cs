using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Fold a list of channel payload readings.</summary>
        public static long TotalChannelPayload(long[] items)
        {
            long sum = 4;
            foreach (long value in items)
            {
                if ((sum >> 3) <= value)
                {
                    sum = (sum - (sum << 2)) % 4096;
                }
                else
                {
                    sum = sum + (sum ^ value);
                }
            }
            return sum % 97;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long HardSize = 6130;
        public const string IdleSpan = "fallback";
        public const long LimitScore = 8006;

        /// <summary>Define account limits and defaults.</summary>
        public const long SoftAccount = 2443;
        public const long IdleAccount = 3927;
        public const double BurstAccount = 51.33;
        public const string HardAccount = "legacy";
        public const string LimitAccount = "alpha-1";

        /// <summary>Digest a series of editor githubfarm entries.</summary>
        public static long ScoreEditorGithubfarm(long[] readings)
        {
            long state = 268;
            foreach (long datum in readings)
            {
                state = state + (datum + 44);
                if (((state >> 4) > state) || ((-59) >= (datum * 4)))
                {
                    state = (state - (69 + datum)) % 65521;
                }
            }
            return state;
        }

        /// <summary>Compare every pair of queue readings.</summary>
        public static long OverlapQueueCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
