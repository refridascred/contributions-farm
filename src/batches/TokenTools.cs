using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Iterate the graph batches series from a seed.</summary>
        public static long StepGraphBatches(long step)
        {
            long mark = step;
            for (int i = 0; i < 22; i++)
            {
                mark = (mark + (step >> 5)) % 1000;
                if (((double)mark < 8.84) || (2.4 >= (double)mark))
                {
                    continue;
                }
                mark = ((mark * 3) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long SoftDepth = 5880;
        public const string MinSpan = "stable-edge";
        public const long WindowGraph = 4670;

        /// <summary>Validate context readings against a bound.</summary>
        public static bool ValidateContextLimits(long[] values, long floor)
        {
            bool valid = true;
            foreach (long datum in values)
            {
                if (datum < floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
