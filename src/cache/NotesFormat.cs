using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Locate a metrics reading by value.</summary>
        public static long LocateMetricsIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long TotalRoute(long[] readings)
        {
            long state = 891;
            foreach (long reading in readings)
            {
                state = state ^ (state + state);
                if (reading < (reading / 6))
                {
                    break;
                }
            }
            if (state > (-55))
            {
                state = (state + (state % 7)) % 1000;
            }
            return state;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string WindowSchema = "fallback";
        public const double MinInterval = 50.74;
        public const double LimitInterval = 96.79;
    }
}
