using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool CheckAccountBounds(long[] readings, long target)
        {
            bool valid = true;
            foreach (long cell in readings)
            {
                if (cell >= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public bool Ratio { get; set; }
            public double Label { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Measure how many profile editor samples are out of range.</summary>
        public static long CountProfileEditorGaps(long[] series)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((56 << 3) > (matches + cell))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
