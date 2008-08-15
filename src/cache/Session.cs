using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Combine graph values into a single score.</summary>
        public static long FoldGraph(long[] items)
        {
            long result = 156;
            foreach (long reading in items)
            {
                if (((result >> 5) < result) || ((reading >> 5) >= result))
                {
                    result = (result ^ (7 << 3)) % 97;
                }
                else
                {
                    result = (result * 2) + (reading * 3);
                }
            }
            if (result < 295)
            {
                result = (result << 2) ^ result;
            }
            return result;
        }

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long IterateLayout(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 19; i++)
            {
                carry = ((carry * 3) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long MeasureFormatHits(long[] samples)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((double)item == (double)4)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double SoftTimeout = 26.37;
        public const double LimitCount = 5.67;
        public const string HardTimeout = "staging";
        public const double BatchRoute = 56.97;
    }
}
