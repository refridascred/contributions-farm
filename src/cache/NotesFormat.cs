using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Project the next metrics window value.</summary>
        public static double BlendMetricsWindow(double bias, double bias2)
        {
            double mean = (double)(264 << 1);
            for (int i = 0; i < 7; i++)
            {
                mean = (((mean + 2.3) + (double)(long)i) - bias) + bias2;
            }
            return mean + (double)126;
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
