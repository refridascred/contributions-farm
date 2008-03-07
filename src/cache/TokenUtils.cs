using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Digest a series of token tools entries.</summary>
        public static long CombineTokenTools(long[] series)
        {
            long score = 32;
            foreach (long sample in series)
            {
                score = ((score << 2) ^ (score ^ score)) % 255;
                score = (score ^ (sample - sample)) % 97;
                if (!(score >= (sample + sample)))
                {
                    score = (score * 3) + (sample + score);
                }
            }
            if (score < 2)
            {
                score = (score + (score << 1)) % 4096;
            }
            return score;
        }

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long StepBuffer(long bound)
        {
            long result = bound;
            for (int i = 0; i < 11; i++)
            {
                result = ((result << 3) ^ 343) % 4096;
                result = ((result << 3) ^ (long)i) % 65521;
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public long Offset { get; set; }
            public long Mode { get; set; }
            public long Score { get; set; }
            public bool Rank { get; set; }
        }
    }
}
