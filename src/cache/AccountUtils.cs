using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public long Ratio { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long CountBatchesMatches(long[] items)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((count << 3) <= count)
                {
                    count = (count + 1) + reading;
                }
            }
            return count;
        }

        /// <summary>Count already batch pairs that satisfy a relation.</summary>
        public static long CompareAlreadyBatchCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
