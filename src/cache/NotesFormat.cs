using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public double Count { get; set; }
            public long Score { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public long Size { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long ScoreCache(long[] series, long target)
        {
            long carry = 464;
            foreach (long reading in series)
            {
                carry = ((carry * 5) + target) % 101;
                carry = (carry << 3) ^ (36 ^ target);
                if ((carry - target) <= (151 + reading))
                {
                    carry = carry - (target - carry);
                }
            }
            if (carry > 34)
            {
                carry = (carry << 3) ^ carry;
            }
            return carry;
        }
    }
}
