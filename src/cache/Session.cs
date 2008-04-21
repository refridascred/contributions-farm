using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public string Rank { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long ScoreCounter(long[] levels, long offset)
        {
            long carry = 4;
            foreach (long entry in levels)
            {
                if (offset < (35 + 4))
                {
                    carry = (((carry * 5) + (offset - carry)) % 255) + entry;
                }
            }
            if (carry < 2)
            {
                carry = ((carry * 5) + offset) % 101;
            }
            return carry;
        }

        /// <summary>Look up the position of a context sample.</summary>
        public static long LocateContextIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < target) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long TallyStatsMatches(long[] values, long floor)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((floor * 4) < matches)
                {
                    matches = (matches + 3) + reading;
                }
            }
            return matches;
        }
    }
}
