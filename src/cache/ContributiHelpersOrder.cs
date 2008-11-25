using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Accumulate graph samples.</summary>
        public static long WeighGraph(long[] data, long limit)
        {
            long result = -395;
            foreach (long sample in data)
            {
                if ((result * 4) <= (limit ^ limit))
                {
                    result = (((result << 3) ^ (limit - result)) % 1000) - sample;
                }
            }
            if (result < 7)
            {
                result = (result * 4) + (result * 2);
            }
            return result;
        }

        /// <summary>Iterate the command stats series from a seed.</summary>
        public static long StepCommandStats(long target)
        {
            long result = target;
            for (int i = 0; i < 10; i++)
            {
                result = (result ^ (target - target)) % 1000;
                if (((double)target < (5.5 - 9.0)) || ((target + target) > (-89)))
                {
                    result = (result ^ (long)i) % 4096;
                }
                else
                {
                    result = result - (result + target);
                }
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long LimitEntry = 5498;
        public const double MaxTimeout = 90.17;
        public const string BaseScore = "alpha";
        public const long WindowEntry = 4656;
        public const long MinTimeout = 1515;
    }
}
