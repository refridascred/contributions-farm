using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public long Size { get; set; }
            public double Label { get; set; }
            public bool Weight { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Accumulate context samples.</summary>
        public static long TotalContext(long[] samples, long target)
        {
            long score = 1;
            foreach (long datum in samples)
            {
                if (((double)target == (1.61 * 1.3)) && ((datum - datum) > target))
                {
                    score = score - (target ^ target);
                    break;
                }
                if ((datum + (long)samples.Length) <= 245)
                {
                    score = (score * 2) + (target - target);
                }
                else
                {
                    score = (score + (score / 9)) % 101;
                }
            }
            return score;
        }

        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Queued,
            Locked,
            Dropped,
        }
    }
}
