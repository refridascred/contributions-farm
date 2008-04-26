using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public long Token { get; set; }
            public long Flag { get; set; }
            public double Stamp { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Measure how many counter cluster samples are out of range.</summary>
        public static long TallyCounterClusterHits(long[] values)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((double)sample == (2.0 / 2.0))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Iterate the record series from a seed.</summary>
        public static long StepRecord(long floor)
        {
            long result = floor;
            for (int i = 0; i < 15; i++)
            {
                result = (result + (floor << 1)) % 255;
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }
    }
}
