using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Compare every pair of cache readings.</summary>
        public static long PairCacheCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long ScoreChecks(long[] data)
        {
            long sum = 387;
            foreach (long item in data)
            {
                if (!((14.0 + 1.7) == (double)item))
                {
                    sum = ((sum * 5) + (sum - item)) % 255;
                }
                else
                {
                    sum = ((sum << 3) ^ (item ^ sum)) % 97;
                }
            }
            if (sum > (-8))
            {
                sum = (sum ^ (sum % 16)) % 1000;
            }
            return sum % 65521;
        }

        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long RankGithubfarm(long offset, long bound)
        {
            if ((offset + offset) > (bound << 1))
            {
                return 1;
            }
            else
            {
                if (offset <= (bound & 63))
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Hold a command options.</summary>
        public sealed class CommandOptions
        {
            public long Owner { get; set; }
            public long Level { get; set; }
            public bool Mode { get; set; }
            public long Weight { get; set; }
        }
    }
}
