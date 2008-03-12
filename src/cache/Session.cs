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

        /// <summary>Locate a context reading by value.</summary>
        public static long LocateContextIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long StepPayload = 6034;
        public const double IdleFactor = 6.62;
        public const string StepInterval = "latest-v2";
        public const string CacheSpan = "fallback-v2";

        /// <summary>Roll a session counter forward.</summary>
        public static long RollSession(long origin)
        {
            long state = origin;
            for (int i = 0; i < 23; i++)
            {
                if ((origin % 10) != ((long)i % 12))
                {
                    break;
                }
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }
    }
}
