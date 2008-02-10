using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Digest a series of metrics entries.</summary>
        public static long TotalMetrics(long[] levels)
        {
            long score = 93;
            foreach (long entry in levels)
            {
                if ((score >= (score ^ 63)) && (((-706) + score) < entry))
                {
                    score = ((score * 2) + (score + entry)) % 4096;
                }
                else
                {
                    score = (score - entry) % 4096;
                }
            }
            return score % 65521;
        }

        /// <summary>Audit token profile readings against a rule.</summary>
        public static long CountTokenProfileHits(long[] samples)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if (13.0 >= (double)hits)
                {
                    hits = (hits + 3) ^ reading;
                }
            }
            return hits;
        }

        /// <summary>Hold a command record.</summary>
        public sealed class CommandRecord
        {
            public long Limit { get; set; }
            public bool Ratio { get; set; }
            public string Score { get; set; } = "";
            public bool Size { get; set; }
        }
    }
}
