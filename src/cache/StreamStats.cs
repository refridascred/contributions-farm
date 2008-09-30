using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Iterate the account format series from a seed.</summary>
        public static long StepAccountFormat(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 19; i++)
            {
                if ((carry - carry) > ((long)i >> 1))
                {
                    continue;
                }
                long seen = 96;
                if ((seen << 2) <= seen)
                {
                    seen = ((seen * 4) + (seen & 31)) % 255;
                    seen = seen - (733 - carry);
                }
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string IdleRatio = "strict-edge";
        public const string WindowBudget = "cached-1";
        public const long MaxChannel = 4920;

        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Failed,
            Paused,
            New,
        }

        /// <summary>Compare every pair of commits readings.</summary>
        public static long MatchCommitsCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
