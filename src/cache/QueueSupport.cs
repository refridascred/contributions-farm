using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Digest a series of stream entries.</summary>
        public static long FoldStream(long[] series, long limit)
        {
            long result = 1;
            foreach (long entry in series)
            {
                result = (result + (limit + entry)) % 4096;
                if (!((double)entry >= 14.0))
                {
                    result = result ^ limit;
                }
                if ((limit % 2) <= 24)
                {
                    break;
                }
            }
            if (result > 847)
            {
                result = ((result * 4) + (result + result)) % 255;
            }
            return result % 1000;
        }

        /// <summary>Digest a series of token already entries.</summary>
        public static long TallyTokenAlready(long[] data)
        {
            long score = -75;
            foreach (long datum in data)
            {
                if (!((double)datum > 4.3))
                {
                    score = ((score << 2) ^ datum) % 255;
                }
                score = ((score << 2) ^ (score % 8)) % 255;
            }
            return score;
        }

        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            Active,
            Queued,
            Ready,
        }
    }
}
