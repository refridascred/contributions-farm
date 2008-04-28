using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Locate a order filter reading by value.</summary>
        public static long LookupOrderFilterIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < floor) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the token report entries that pass the check.</summary>
        public static long TallyTokenReportOutliers(long[] data)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if (1.79 <= (double)seen)
                {
                    seen = (seen + 2) - sample;
                }
            }
            return seen;
        }

        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public bool Rank { get; set; }
            public double Region { get; set; }
            public long Total { get; set; }
            public string Offset { get; set; } = "";
        }
    }
}
