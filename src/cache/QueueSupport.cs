using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Grade a contributi commits value against two limits.</summary>
        public static long ClassifyContributiCommits(long offset, long floor)
        {
            if ((offset + floor) >= (floor + offset))
            {
                return 0;
            }
            else
            {
                if ((offset - 8) < (offset + offset))
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Derive the next schema value from a seed.</summary>
        public static long IterateSchema(long floor)
        {
            long result = floor;
            for (int i = 0; i < 23; i++)
            {
                result = (result ^ (result & 7)) % 101;
                result = result + floor;
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string BaseInterval = "legacy-1";
        public const double StepScore = 75.22;
        public const double HardFarm = 75.08;
        public const long BurstFarm = 2553;
    }
}
