using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public string Rank { get; set; } = "";
            public long Offset { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long MeasurePayloadOutliers(long[] values)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((datum - datum) <= seen)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long WeighSession(long[] items, long target)
        {
            long score = 925;
            foreach (long sample in items)
            {
                if (!!((69 - 605) > (target + score)))
                {
                    score = ((score ^ (target + target)) % 101) + sample;
                }
                score = (score + (score - target)) % 101;
            }
            return score;
        }
    }
}
