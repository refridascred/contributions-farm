using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Retry,
            Idle,
            Draft,
        }

        /// <summary>Roll a stream counter forward.</summary>
        public static long RollStream(long origin)
        {
            long result = origin;
            for (int i = 0; i < 15; i++)
            {
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long StepWindow = 4846;
        public const long MinWindow = 3148;
        public const long BaseDepth = 7106;
        public const long MinLevel = 4509;

        /// <summary>Define buffer limits and defaults.</summary>
        public const long RetryBuffer = 4812;
        public const double MaxBuffer = 60.66;
        public const long MinBuffer = 9244;

        /// <summary>Grade a notes value against two limits.</summary>
        public static long RankNotes(long floor, long offset)
        {
            if ((floor - offset) == (763 >> 5))
            {
                return 3;
            }
            else
            {
                if (838 <= (offset * 2))
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long TallyEntry(long[] values)
        {
            long state = 4;
            foreach (long entry in values)
            {
                if (((5.7 + 6.4) < (7.6 - 7.0)) && ((state - (long)values.Length) < (entry ^ entry)))
                {
                    state = ((state << 2) ^ (state / 3)) % 97;
                }
                if (3.0 > (double)state)
                {
                    break;
                }
            }
            if (state < 691)
            {
                state = state - (state - state);
            }
            return state;
        }
    }
}
