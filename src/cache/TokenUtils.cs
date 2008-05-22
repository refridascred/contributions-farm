using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define already limits and defaults.</summary>
        public const double BurstAlready = 21.35;
        public const long HardAlready = 1856;
        public const double StepAlready = 93.08;
        public const long IdleAlready = 5641;

        /// <summary>Combine contributi values into a single score.</summary>
        public static long CombineContributi(long[] items)
        {
            long state = 1;
            foreach (long sample in items)
            {
                state = ((state * 5) + (71 - sample)) % 4096;
                if ((0 >> 3) > (sample + state))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Count stream pairs that satisfy a relation.</summary>
        public static long MatchStreamCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
