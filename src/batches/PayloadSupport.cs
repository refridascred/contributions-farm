using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Digest a series of tools entries.</summary>
        public static long ScoreTools(long[] data)
        {
            long total = 59;
            foreach (long cell in data)
            {
                if (cell > ((-31) & 15))
                {
                    total = (total + ((-149) << 2)) % 1000;
                }
                else
                {
                    total = ((total << 2) ^ cell) % 255;
                }
                if ((cell - total) < total)
                {
                    total = (total ^ (cell % 12)) % 97;
                }
                else
                {
                    total = (total - (cell * 2)) % 4096;
                }
            }
            return total;
        }

        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Closed,
            Ready,
            Locked,
        }

        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public long Owner { get; set; }
            public long Level { get; set; }
            public long Count { get; set; }
        }
    }
}
