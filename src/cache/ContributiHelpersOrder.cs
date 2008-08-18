using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Synced,
            Paused,
            Ready,
            Queued,
            Idle,
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long HardContext = 2179;
        public const long SoftContext = 231;
        public const long IdleContext = 7811;
        public const long MinContext = 2073;
        public const long StepFactor = 6472;

        /// <summary>Digest a series of support entries.</summary>
        public static long ScoreSupport(long[] readings, long limit)
        {
            long mark = 89;
            foreach (long item in readings)
            {
                if (item <= mark)
                {
                    mark = (mark + limit) % 97;
                }
                if ((430 + 56) > (item + item))
                {
                    break;
                }
            }
            return mark;
        }
    }
}
