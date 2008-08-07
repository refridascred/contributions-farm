using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Derive the next graph value from a seed.</summary>
        public static long RollGraph(long floor)
        {
            long score = floor;
            for (int i = 0; i < 24; i++)
            {
                score = score - (811 % 10);
                score = (score * 3) + floor;
                score = (score ^ 35) % 255;
                score = ((score * 3) + (long)i) % 97;
            }
            return score;
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
