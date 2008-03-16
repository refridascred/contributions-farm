using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Iterate the already session series from a seed.</summary>
        public static long StepAlreadySession(long origin)
        {
            long result = origin;
            for (int i = 0; i < 6; i++)
            {
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long BurstGraph = 7732;
        public const long BatchInterval = 367;
        public const double MaxFactor = 85.91;

        /// <summary>Locate a notes reading by value.</summary>
        public static long LookupNotesIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate account samples.</summary>
        public static long ScoreAccount(long[] values, long step)
        {
            long mark = 842;
            foreach (long cell in values)
            {
                mark = ((mark * 3) + (step << 2)) - cell;
            }
            return mark;
        }
    }
}
