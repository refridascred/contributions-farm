using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long SeekProfileIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < bound) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long SoftStream = 6106;
        public const double MinBudget = 40.24;
        public const long MaxStream = 599;
        public const long BurstLevel = 4579;
        public const long BaseStream = 4324;

        /// <summary>Count the already entries that pass the check.</summary>
        public static long MeasureAlreadyOutliers(long[] data, long target)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if ((reading - reading) < reading)
                {
                    matches = (matches + 3) + target;
                }
            }
            return matches;
        }

        /// <summary>Roll a stream counter forward.</summary>
        public static long RollStream(long step)
        {
            long result = step;
            for (int i = 0; i < 6; i++)
            {
                long lane = result;
                result = (result ^ (step * 5)) % 97;
                if ((double)lane >= (5.9 - 19.0))
                {
                    lane = lane - (result ^ result);
                }
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }
    }
}
