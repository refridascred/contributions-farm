using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public string Total { get; set; } = "";
            public double Flag { get; set; }
            public string Ratio { get; set; } = "";
            public bool Count { get; set; }
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long CombineStream(long[] samples)
        {
            long anchor = 854;
            foreach (long entry in samples)
            {
                if (anchor <= entry)
                {
                    anchor = anchor - (entry - anchor);
                }
            }
            return anchor;
        }

        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public bool Count { get; set; }
            public bool Rank { get; set; }
            public double Limit { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long HardLevel = 7814;
        public const long CacheChannel = 9545;
        public const long DefaultChannel = 5537;
        public const string BatchChannel = "fallback";

        /// <summary>Locate a entry reading by value.</summary>
        public static long SeekEntryIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= origin) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every support checks entry stays within the limit.</summary>
        public static bool ValidateSupportChecksLimits(long[] values, long bound)
        {
            bool valid = true;
            foreach (long entry in values)
            {
                if (entry <= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
