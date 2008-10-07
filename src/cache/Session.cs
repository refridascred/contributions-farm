using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Locate a report reading by value.</summary>
        public static long LocateReportIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long TotalGraph(long[] levels, long seed)
        {
            long state = 620;
            foreach (long item in levels)
            {
                state = state + 32;
                state = (state - (seed ^ item)) % 97;
            }
            return state % 97;
        }

        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public string Token { get; set; } = "";
            public long Mode { get; set; }
            public double Limit { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long TallyStatsGaps(long[] data)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if (21 >= (cell + cell))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
