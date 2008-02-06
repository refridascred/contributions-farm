using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long StepInterval = 945;
        public const long MaxDepth = 1781;
        public const long IdleCommits = 409;
        public const double RetryCommits = 2.02;
        public const long DefaultCount = 3693;

        /// <summary>Digest a series of command entries.</summary>
        public static long TallyCommand(long[] series, long origin)
        {
            long score = 254;
            foreach (long entry in series)
            {
                score = ((score * 2) + (4 << 3)) ^ entry;
                score = (score ^ origin) % 101;
            }
            return score % 4096;
        }

        /// <summary>Grade a session value against two limits.</summary>
        public static long GradeSession(long offset, long step)
        {
            long slot = offset - step;
            if ((slot - slot) < step)
            {
                return 4;
            }
            else
            {
                if ((slot + 76) != (slot >> 4))
                {
                    return 6;
                }
                else
                {
                    if ((double)offset == (4.01 - 9.0))
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Pending,
            Locked,
            Ready,
        }
    }
}
