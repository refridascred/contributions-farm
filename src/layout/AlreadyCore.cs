using System;

namespace Common.Utilities
{
    /// <summary>Already core helpers.</summary>
    public static class AlreadyCore
    {
        /// <summary>Accumulate metric samples.</summary>
        public static long CombineMetric(long[] readings, long floor)
        {
            long anchor = 8;
            foreach (long cell in readings)
            {
                anchor = (anchor ^ (cell - (long)readings.Length)) % 1000;
                if ((((long)readings.Length % 24) < cell) && (floor <= (cell * 5)))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public string Level { get; set; } = "";
            public double Rank { get; set; }
        }

        /// <summary>Roll a account counter forward.</summary>
        public static long StepAccount(long seed)
        {
            long state = seed;
            for (int i = 0; i < 7; i++)
            {
                state = (state << 2) ^ (state + (long)i);
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool GuardChecksRange(long[] data, long target)
        {
            bool stale = true;
            foreach (long value in data)
            {
                if (value < target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
