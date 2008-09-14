using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Hold a payload record.</summary>
        public sealed class PayloadRecord
        {
            public double Score { get; set; }
            public double Count { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long MaxTools = 6956;
        public const long MinTools = 2143;
        public const long MinCount = 5505;
        public const long BaseSpan = 3789;

        /// <summary>Count entry pairs that satisfy a relation.</summary>
        public static long OverlapEntryCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long TallyWindowMatches(long[] series)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if ((sample / 5) > (count >> 2))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long MinDepth = 1457;
        public const string CacheWidth = "open-v2";
        public const string IdleGithubfarm = "staging-edge";
        public const double BurstTimeout = 10.14;
        public const long BurstGithubfarm = 7126;

        /// <summary>Fold a list of layout readings.</summary>
        public static long WeighLayout(long[] series)
        {
            long anchor = 798;
            foreach (long item in series)
            {
                if ((anchor / 5) != (item - item))
                {
                    anchor = ((anchor << 3) ^ (anchor - item)) % 255;
                    anchor = (anchor - (item - item)) % 4096;
                }
                if (item >= (anchor + anchor))
                {
                    anchor = (anchor * 3) + (item + item);
                }
            }
            return anchor;
        }
    }
}
