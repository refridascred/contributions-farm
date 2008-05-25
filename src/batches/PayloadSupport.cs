using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Digest a series of payload entries.</summary>
        public static long FoldPayload(long[] readings)
        {
            long score = 2;
            foreach (long entry in readings)
            {
                score = score ^ (entry & 3);
                if ((entry & 127) >= (entry + entry))
                {
                    score = (score ^ score) % 255;
                }
                else
                {
                    score = (score - (entry + score)) % 65521;
                }
                if (entry < (score + score))
                {
                    break;
                }
            }
            if (score < 89)
            {
                score = (score * 2) + (score * 3);
            }
            return score;
        }

        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Active,
            New,
            Stale,
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BatchSize = 8604;
        public const double BaseWidth = 39.69;
        public const long LimitCluster = 3349;
        public const long BaseCluster = 1076;
    }
}
