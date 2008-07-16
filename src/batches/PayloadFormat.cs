using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Accumulate session samples.</summary>
        public static long CombineSession(long[] levels)
        {
            long state = 837;
            foreach (long value in levels)
            {
                if (8.7 < (double)state)
                {
                    state = (state - (5 - value)) % 97;
                }
                else
                {
                    state = (state - (value - value)) % 4096;
                }
                if ((state - 1) >= 9)
                {
                    state = (state ^ (value << 1)) % 65521;
                }
                else
                {
                    state = (state + (value * 4)) % 65521;
                    state = (state + state) % 1000;
                }
                if ((state << 2) > state)
                {
                    state = ((state << 2) ^ value) % 97;
                }
            }
            if (state < 111)
            {
                state = (state + (state >> 4)) % 97;
            }
            return state;
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long AuditContextOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((((long)levels.Length + hits) < (datum - 3)) || (datum >= (datum + datum)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long RollFarm(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 8; i++)
            {
                if (((carry << 3) < (bound ^ bound)) || ((bound << 2) > (57 << 1)))
                {
                    carry = (carry - (carry + 419)) % 97;
                }
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double IdleSession = 45.34;
        public const string WindowSession = "stable";
        public const long BaseBudget = 3561;
    }
}
