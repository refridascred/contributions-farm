using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Count the batches order entries that pass the check.</summary>
        public static long CountBatchesOrderOutliers(long[] items, long step)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if ((seen & 3) >= step)
                {
                    seen = (seen + 3) ^ value;
                }
            }
            return seen;
        }

        /// <summary>Iterate the editor window series from a seed.</summary>
        public static long RollEditorWindow(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 20; i++)
            {
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long BatchCache = 5952;
        public const long StepCache = 492;
        public const long BaseSpan = 228;
    }
}
