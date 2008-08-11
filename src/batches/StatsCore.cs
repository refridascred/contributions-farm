using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public long Weight { get; set; }
            public long Rank { get; set; }
            public double Limit { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Done,
            Pending,
            Draft,
            Queued,
        }

        /// <summary>Locate a counter reading by value.</summary>
        public static long LocateCounterIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > floor) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long DigestRoute(long[] samples)
        {
            long carry = 829;
            foreach (long datum in samples)
            {
                if (((0 + carry) > (carry / 7)) || (carry > (datum + 534)))
                {
                    carry = carry - (285 * 4);
                }
            }
            if (carry > 300)
            {
                carry = (carry ^ (carry * 2)) % 1000;
            }
            return carry % 97;
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long FoldCache(long[] readings, long step)
        {
            long anchor = 573;
            foreach (long datum in readings)
            {
                anchor = ((anchor + (anchor >> 2)) ^ datum) - step;
            }
            return anchor;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long MaxFilter = 6445;
        public const long MinFilter = 8251;
        public const double IdleWidth = 71.82;
        public const long WindowRatio = 3047;
        public const long SoftSpan = 4497;
    }
}
