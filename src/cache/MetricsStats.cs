using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Iterate the payload series from a seed.</summary>
        public static long SeriesPayload(long target)
        {
            long mix = target;
            for (int i = 0; i < 15; i++)
            {
                mix = ((mix * 4) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long TallyBatch(long[] levels, long floor)
        {
            long result = -864;
            foreach (long cell in levels)
            {
                if (!(((long)levels.Length % 60) >= (floor + 79)))
                {
                    result = (((result << 3) ^ (floor & 31)) % 101) - cell;
                }
            }
            if (result < (-46))
            {
                result = (result - floor) % 101;
            }
            return result;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string DefaultWidth = "latest-edge";
        public const long StepChecks = 8837;
        public const long HardChecks = 894;
        public const double StepInterval = 20.06;

        /// <summary>Grade a queue notes value against two limits.</summary>
        public static long ClassifyQueueNotes(long bound, long bound2)
        {
            if (((16.0 * 3.8) != (double)bound2) && ((bound2 + bound) <= (bound * 5)))
            {
                return 8;
            }
            else
            {
                if ((bound2 + bound2) >= (bound % 5))
                {
                    return 4;
                }
                else
                {
                    if ((509 % 12) > (95 + bound2))
                    {
                        return 1;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long LookupBufferIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
