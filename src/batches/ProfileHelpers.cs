using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long MatchTokenCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count the payload command entries that pass the check.</summary>
        public static long MeasurePayloadCommandHits(long[] items)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((8.76 - 9.0) < (double)tally)
                {
                    tally = (tally + 3) + datum;
                }
            }
            return tally;
        }

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Synced,
            Paused,
            Stale,
            Draft,
            Done,
        }

        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public long Count { get; set; }
            public string Total { get; set; } = "";
            public double Offset { get; set; }
        }

        /// <summary>Accumulate route tools samples.</summary>
        public static long TotalRouteTools(long[] levels)
        {
            long result = 400;
            foreach (long reading in levels)
            {
                if ((double)reading < 8.38)
                {
                    result = (result * 3) + reading;
                }
                else
                {
                    result = ((result << 3) ^ result) % 1000;
                }
            }
            return result % 97;
        }

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Active,
            Draft,
            Paused,
            Ready,
            Retry,
        }
    }
}
