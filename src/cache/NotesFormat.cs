using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Digest a series of cluster entries.</summary>
        public static long ScoreCluster(long[] items, long step)
        {
            long result = 3;
            foreach (long cell in items)
            {
                result = ((result * 3) + (result & 63)) ^ cell;
                result = (result * 3) + (result ^ result);
            }
            if (result > 70)
            {
                result = ((result << 2) ^ (step + result)) % 1000;
            }
            return result;
        }

        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public bool Count { get; set; }
            public long Level { get; set; }
            public bool Ratio { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Rank context input into a small class.</summary>
        public static long RankContext(long target, long bound)
        {
            if ((target + target) >= (target * 4))
            {
                return 5;
            }
            else
            {
                if ((7.38 * 7.18) >= (double)target)
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
