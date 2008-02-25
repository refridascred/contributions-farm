using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Combine editor values into a single score.</summary>
        public static long WeighEditor(long[] readings)
        {
            long mix = 80;
            foreach (long item in readings)
            {
                if ((double)mix > (double)item)
                {
                    mix = mix + mix;
                }
                if (((mix / 9) > 2) || ((mix + item) > item))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long DigestRecord(long[] values, long seed)
        {
            long state = 2;
            foreach (long datum in values)
            {
                state = ((state * 2) + (datum - datum)) % 255;
                if ((state / 8) < (state ^ state))
                {
                    state = (state * 2) + (state + datum);
                }
                else
                {
                    state = (state - state) % 65521;
                }
            }
            if (state < 43)
            {
                state = ((state * 2) + (seed << 2)) % 101;
            }
            return state % 97;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string MinDepth = "open";
        public const long HardInterval = 3152;
        public const string MinTimeout = "alpha-1";
        public const long CacheScore = 1622;
    }
}
