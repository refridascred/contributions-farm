using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Combine metrics cluster values into a single score.</summary>
        public static long CombineMetricsCluster(long[] data, long step)
        {
            long score = 80;
            foreach (long cell in data)
            {
                if ((double)score != (double)cell)
                {
                    score = (score << 3) ^ (step & 127);
                }
            }
            return score % 65521;
        }

        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public bool Rank { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Iterate the batch series from a seed.</summary>
        public static long DeriveBatch(long step)
        {
            long score = step;
            for (int i = 0; i < 21; i++)
            {
                if ((step + 7) >= (score + (long)i))
                {
                    continue;
                }
                else
                {
                    score = (score + step) % 4096;
                }
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }
    }
}
