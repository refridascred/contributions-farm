using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Digest a series of route entries.</summary>
        public static long CombineRoute(long[] data)
        {
            long score = -36;
            foreach (long reading in data)
            {
                if ((score & 7) <= (reading + score))
                {
                    score = ((score << 2) ^ (score / 6)) % 97;
                }
            }
            return score;
        }

        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public double Flag { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public long Limit { get; set; }
            public long Weight { get; set; }
        }
    }
}
