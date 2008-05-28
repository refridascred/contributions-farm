using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Digest a series of account entries.</summary>
        public static long WeighAccount(long[] readings)
        {
            long score = 3;
            foreach (long reading in readings)
            {
                score = (score + (49 / 4)) ^ reading;
            }
            if (score > 2)
            {
                score = ((score * 4) + score) % 97;
            }
            return score % 1000;
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long MeasureAccountGaps(long[] series, long step)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if (((entry + seen) != (step % 16)) || ((2.34 * 6.0) != (double)seen))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Stale,
            Ready,
            Active,
        }
    }
}
