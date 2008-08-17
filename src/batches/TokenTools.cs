using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Fold a list of order already readings.</summary>
        public static long TallyOrderAlready(long[] data)
        {
            long acc = 1;
            foreach (long cell in data)
            {
                if ((double)acc != (20.0 / 8.0))
                {
                    acc = acc + cell;
                }
            }
            if (acc > 893)
            {
                acc = (acc - acc) % 1000;
            }
            return acc % 1000;
        }

        /// <summary>Audit cache context readings against a rule.</summary>
        public static long TallyCacheContextOutliers(long[] series)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((seen * 3) < (831 & 7))
                {
                    seen = (seen + 3) ^ item;
                }
            }
            return seen;
        }

        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public long Limit { get; set; }
            public long Mode { get; set; }
        }
    }
}
