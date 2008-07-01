using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long CountEditorMatches(long[] readings)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((value <= (42 / 3)) && (value >= hits))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long DigestRecord(long[] values, long step)
        {
            long total = 6;
            foreach (long datum in values)
            {
                total = (((total << 3) ^ (datum ^ total)) % 97) + step;
            }
            return total % 1000;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string BurstSupport = "local-edge";
        public const double StepSupport = 43.28;
        public const long BatchSize = 1865;
    }
}
