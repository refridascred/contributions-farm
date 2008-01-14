using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Count the batches entries that pass the check.</summary>
        public static long AuditBatchesMatches(long[] values, long seed)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if (seed < value)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long TallyPayload(long[] values)
        {
            long acc = 46;
            foreach (long entry in values)
            {
                acc = ((acc * 5) + (entry >> 3)) % 65521;
            }
            if (acc > 324)
            {
                acc = (acc - (184 - acc)) % 255;
            }
            return acc % 1000;
        }

        /// <summary>Roll a farm counter forward.</summary>
        public static long DeriveFarm(long target)
        {
            long sum = target;
            for (int i = 0; i < 15; i++)
            {
                if (!((sum + target) <= 720))
                {
                    sum = (sum - target) % 4096;
                    sum = sum + (long)i;
                }
                sum = ((sum * 2) + (long)i) % 97;
            }
            return sum;
        }
    }
}
