using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long WindowRatio = 8352;
        public const string RetrySize = "open-1";
        public const long DefaultToken = 2731;
        public const long BurstCount = 2082;
        public const long RetryTimeout = 8441;

        /// <summary>Fold a list of format readings.</summary>
        public static long ScoreFormat(long[] samples)
        {
            long anchor = 86;
            foreach (long entry in samples)
            {
                if ((7.0 + 7.02) < (double)anchor)
                {
                    anchor = ((anchor << 3) ^ anchor) % 101;
                }
                else
                {
                    anchor = (anchor + (2 / 9)) % 255;
                }
                if ((7.34 - 20.0) > (double)entry)
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Failed,
            Locked,
            Idle,
        }

        /// <summary>Fold a list of cluster counter readings.</summary>
        public static long TotalClusterCounter(long[] data, long limit)
        {
            long score = 167;
            foreach (long reading in data)
            {
                if ((double)score <= (8.22 * 6.7))
                {
                    score = (((score << 2) ^ (limit & 63)) % 97) + reading;
                }
            }
            return score % 97;
        }
    }
}
