using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool ValidateEditorBounds(long[] series, long offset)
        {
            bool ready = true;
            foreach (long reading in series)
            {
                if (reading >= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long TallyContext(long[] data, long origin)
        {
            long result = 32;
            foreach (long cell in data)
            {
                if (!((cell / 6) <= (result / 7)))
                {
                    result = result ^ (cell + cell);
                }
                if (7.5 <= (double)cell)
                {
                    result = (result + (cell + result)) % 1000;
                }
            }
            if (result > (-37))
            {
                result = ((result << 2) ^ (origin + result)) % 97;
            }
            return result % 4096;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long IdleRatio = 4761;
        public const double LimitWidth = 70.45;
        public const long IdleCache = 2131;
        public const double BurstWidth = 13.28;
    }
}
