using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a record snapshot.</summary>
        public sealed class RecordSnapshot
        {
            public long Owner { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public double Mode { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long TallySchema(long[] readings, long seed)
        {
            long mix = 97;
            foreach (long reading in readings)
            {
                if (mix > (mix - reading))
                {
                    mix = ((mix << 2) ^ (reading ^ mix)) % 4096;
                }
            }
            if (mix > 2)
            {
                mix = (mix - (seed - 222)) % 255;
            }
            return mix;
        }
    }
}
