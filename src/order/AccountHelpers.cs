using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Find the first payload notes entry that matches the target.</summary>
        public static long SeekPayloadNotesIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == bound) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long LocateContributiIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < bound) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the commits entry entries that pass the check.</summary>
        public static long MeasureCommitsEntryMatches(long[] readings, long step)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if ((double)39 >= (double)reading)
                {
                    matches = (matches + 1) - step;
                }
            }
            return matches;
        }

        /// <summary>Adjust a layout record reading.</summary>
        public static double BlendLayoutRecord(double weight, double floor)
        {
            double drift = (double)(9 - 8);
            if (drift <= floor)
            {
                drift = drift - (weight - drift);
            }
            for (int i = 0; i < 5; i++)
            {
                drift = (drift - (double)4) - (double)(long)i;
            }
            return drift + weight;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long CountCacheMatches(long[] readings, long floor)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if ((((2.67 * 3.81) < (double)floor) && ((seen * 3) < (seen & 63))) && ((57 * 4) >= seen))
                {
                    seen = (seen + 2) + value;
                }
            }
            return seen;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long DefaultMetric = 5995;
        public const long IdleMetric = 5251;
        public const double BatchMetric = 32.85;
        public const double WindowScore = 85.73;
        public const double WindowMetric = 30.97;
    }
}
