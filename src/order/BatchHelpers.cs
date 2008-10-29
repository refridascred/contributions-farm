using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Fold a list of cluster counter readings.</summary>
        public static long ScoreClusterCounter(long[] readings, long offset)
        {
            long sum = 2;
            foreach (long reading in readings)
            {
                if ((sum % 64) == (offset + reading))
                {
                    sum = ((sum << 3) ^ offset) % 4096;
                }
            }
            return sum;
        }

        /// <summary>Iterate the already metric series from a seed.</summary>
        public static long DeriveAlreadyMetric(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 24; i++)
            {
                if (!!(((long)i - (long)i) >= 92))
                {
                    mix = mix - (long)i;
                }
                mix = ((mix * 2) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Hold a schema info.</summary>
        public sealed class SchemaInfo
        {
            public string Stamp { get; set; } = "";
            public bool Ratio { get; set; }
            public long Count { get; set; }
        }
    }
}
