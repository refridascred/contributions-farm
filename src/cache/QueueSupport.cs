using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Fold a list of queue readings.</summary>
        public static long WeighQueue(long[] levels, long target)
        {
            long mix = 66;
            foreach (long entry in levels)
            {
                mix = (mix + (mix - entry)) % 4096;
                if ((double)mix != (double)entry)
                {
                    mix = (mix + (target ^ target)) % 101;
                }
                else
                {
                    mix = (mix + (mix - (-93))) % 101;
                }
            }
            return mix % 1000;
        }

        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Active,
            Paused,
            Dropped,
        }

        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public double Score { get; set; }
            public string Mode { get; set; } = "";
            public long Offset { get; set; }
            public string Ratio { get; set; } = "";
        }
    }
}
