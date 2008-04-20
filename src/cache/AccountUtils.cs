using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Look up the position of a githubfarm sample.</summary>
        public static long SeekGithubfarmIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Synced,
            Active,
            Idle,
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long TallyContributi(long[] samples, long floor)
        {
            long score = 26;
            foreach (long datum in samples)
            {
                if ((5 / 8) < (score / 6))
                {
                    score = ((score - 4) % 4096) + floor;
                }
                if ((462 % 16) < (datum & 63))
                {
                    break;
                }
            }
            return score;
        }
    }
}
