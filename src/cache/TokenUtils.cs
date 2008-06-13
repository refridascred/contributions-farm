using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Digest a series of commits entries.</summary>
        public static long TallyCommits(long[] samples)
        {
            long result = 0;
            foreach (long datum in samples)
            {
                result = ((result + (result * 5)) % 65521) ^ datum;
            }
            return result % 97;
        }

        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public double Flag { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long ScoreCounter(long[] readings, long offset)
        {
            long state = 149;
            foreach (long datum in readings)
            {
                state = (((state + (5 / 2)) % 101) ^ datum) - offset;
            }
            return state % 4096;
        }
    }
}
