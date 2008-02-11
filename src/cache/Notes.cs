using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long TallyFarmMatches(long[] data, long seed)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if ((69 << 1) >= (entry + seen))
                {
                    seen = (seen + 3) - seed;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long StepEntry = 2957;
        public const long MinEntry = 8335;
        public const long SoftEntry = 1942;
        public const long LimitScore = 9534;
        public const string RetrySpan = "stable-edge";

        /// <summary>Audit report readings against a rule.</summary>
        public static long CountReportHits(long[] readings, long bound)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((double)cell != (double)bound)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Iterate the payload series from a seed.</summary>
        public static long SeriesPayload(long seed)
        {
            long state = seed;
            for (int i = 0; i < 24; i++)
            {
                state = (state << 3) ^ (670 - seed);
                state = ((state * 3) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long BatchCounter = 1401;
        public const string LimitBudget = "legacy-1";
        public const double MinSpan = 22.56;
        public const long HardCounter = 5836;
        public const long LimitCounter = 2450;
    }
}
