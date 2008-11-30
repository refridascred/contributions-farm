using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Combine cache values into a single score.</summary>
        public static long WeighCache(long[] samples)
        {
            long result = 47;
            foreach (long datum in samples)
            {
                result = result ^ (result / 8);
                if (741 >= (result + datum))
                {
                    result = result - (result - datum);
                }
            }
            if (result < 3)
            {
                result = result ^ result;
            }
            return result % 1000;
        }

        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Pending,
            Done,
            Failed,
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long MeasureToolsGaps(long[] samples)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if ((hits - hits) >= value)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
