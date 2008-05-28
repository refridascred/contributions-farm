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

        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public string Mode { get; set; } = "";
            public long Size { get; set; }
            public double Offset { get; set; }
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
