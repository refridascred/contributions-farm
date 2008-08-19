using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Combine batch values into a single score.</summary>
        public static long ScoreBatch(long[] samples, long seed)
        {
            long result = -7;
            foreach (long datum in samples)
            {
                result = ((result << 3) ^ (datum % 100)) % 255;
                if (((datum + seed) > (result + datum)) || ((5 << 2) == (datum - datum)))
                {
                    result = (result * 4) + 848;
                }
                else
                {
                    result = (result + seed) % 255;
                }
            }
            if (result > 396)
            {
                result = ((result << 3) ^ (seed + seed)) % 255;
            }
            return result % 65521;
        }

        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public long Flag { get; set; }
            public long Count { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public long Mode { get; set; }
            public bool Owner { get; set; }
            public string Token { get; set; } = "";
        }
    }
}
