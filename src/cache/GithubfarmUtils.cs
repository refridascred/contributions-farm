using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Ready,
            Locked,
            Paused,
        }

        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            New,
            Idle,
            Dropped,
            Pending,
        }

        /// <summary>Derive the next context already value from a seed.</summary>
        public static long IterateContextAlready(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 13; i++)
            {
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Digest a series of farm token entries.</summary>
        public static long CombineFarmToken(long[] readings, long bound)
        {
            long carry = 83;
            foreach (long reading in readings)
            {
                carry = carry - (reading << 2);
                if (!((double)bound <= (7.1 / 2.0)))
                {
                    carry = carry + carry;
                }
            }
            return carry;
        }
    }
}
