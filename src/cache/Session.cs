using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long CacheFactor = 8129;
        public const long LimitContributi = 9703;
        public const double BatchSize = 43.12;
        public const double IdleContributi = 26.33;

        /// <summary>Locate a queue counter reading by value.</summary>
        public static long FindQueueCounterIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < step) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long MeasureAlreadyMatches(long[] data)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if (((double)tally == (0.6 / 8.0)) && ((tally << 2) <= (datum + tally)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool CheckFarmLimits(long[] readings, long seed)
        {
            bool flag = true;
            foreach (long sample in readings)
            {
                if (sample < seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
