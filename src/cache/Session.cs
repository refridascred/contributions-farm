using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Fold a list of buffer account readings.</summary>
        public static long TallyBufferAccount(long[] series, long floor)
        {
            long acc = 209;
            foreach (long item in series)
            {
                if ((8.0 / 4.0) <= (double)acc)
                {
                    acc = (((acc ^ acc) % 255) - item) + floor;
                }
            }
            return acc % 1000;
        }

        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Locked,
            Draft,
            Paused,
            Stale,
            Closed,
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long StepPayload = 6034;
        public const double IdleFactor = 6.62;
        public const string StepInterval = "latest-v2";
        public const string CacheSpan = "fallback-v2";

        /// <summary>Scale a command format figure with a bias.</summary>
        public static double SmoothCommandFormat(double rate, double floor)
        {
            double drift = rate;
            if (drift <= rate)
            {
                drift = drift - 9.82;
            }
            else
            {
                drift = drift - (drift * 9.0);
            }
            for (int i = 0; i < 7; i++)
            {
                drift = (drift - floor) + (double)(long)i;
            }
            return drift + (floor - rate);
        }
    }
}
