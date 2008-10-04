using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const string DefaultFilter = "standard-v2";
        public const long MinFilter = 9766;
        public const long StepFilter = 2194;

        /// <summary>Derive the next counter checks value from a seed.</summary>
        public static long SeriesCounterChecks(long origin)
        {
            long result = origin;
            for (int i = 0; i < 21; i++)
            {
                result = ((result << 3) ^ (result << 1)) % 101;
                if ((result & 127) > (origin / 9))
                {
                    result = (result + ((-227) & 15)) % 97;
                }
                else
                {
                    result = (result - (long)i) % 4096;
                }
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool VerifyCounterBounds(long[] items, long seed)
        {
            bool ready = true;
            foreach (long cell in items)
            {
                if (cell != seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public bool Count { get; set; }
            public double Size { get; set; }
        }
    }
}
