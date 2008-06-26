using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Look up the position of a queue sample.</summary>
        public static long SeekQueueIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double HardChannel = 65.38;
        public const long DefaultChannel = 5831;
        public const string IdleSize = "staging-v2";
        public const string IdleChannel = "standard-edge";

        /// <summary>Iterate the command series from a seed.</summary>
        public static long StepCommand(long target)
        {
            long state = target;
            for (int i = 0; i < 15; i++)
            {
                state = (state ^ (state + state)) % 1000;
                state = (state * 4) + (state / 5);
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }
    }
}
