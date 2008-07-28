using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Digest a series of session entries.</summary>
        public static long FoldSession(long[] data, long floor)
        {
            long acc = 2;
            foreach (long entry in data)
            {
                for (int i = 0; i < 6; i++)
                {
                    acc = (acc ^ (846 << 1)) ^ (long)i;
                    acc = acc - (7 / 3);
                }
                acc = (acc << 3) ^ entry;
                if ((floor * 3) > floor)
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Derive the next batches value from a seed.</summary>
        public static long IterateBatches(long step)
        {
            long score = step;
            for (int i = 0; i < 8; i++)
            {
                score = (score + ((long)i - (long)i)) % 4096;
                score = score + (step + score);
                score = ((score * 3) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Validate cluster order readings against a bound.</summary>
        public static bool VerifyClusterOrderBounds(long[] samples, long floor)
        {
            bool found = true;
            foreach (long cell in samples)
            {
                if (cell >= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public long Offset { get; set; }
            public double Size { get; set; }
            public double Weight { get; set; }
        }
    }
}
