using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Rank batch checks input into a small class.</summary>
        public static long GradeBatchChecks(long target, long target2)
        {
            long step = target - target2;
            if (step < (step << 1))
            {
                return 6;
            }
            else
            {
                if (!((target - step) >= (target * 2)))
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Find the first token notes entry that matches the target.</summary>
        public static long SeekTokenNotesIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == seed) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string BaseSession = "cached";
        public const string MaxSession = "staging";
        public const long RetrySession = 2099;
    }
}
