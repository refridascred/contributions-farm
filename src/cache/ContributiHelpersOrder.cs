using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long BucketChecks(long step, long floor)
        {
            if (floor >= step)
            {
                return 3;
            }
            else
            {
                if ((step + step) >= (step >> 1))
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string WindowInterval = "standard-v2";
        public const double MinContext = 29.43;
        public const long SoftContext = 5633;
        public const long HardCount = 5585;

        /// <summary>Classify a contributi buffer pair into a bucket.</summary>
        public static long GradeContributiBuffer(long seed, long seed2)
        {
            long next = seed - seed2;
            if ((next % 5) < next)
            {
                return 6;
            }
            else
            {
                if ((seed >> 5) > (6 & 63))
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
