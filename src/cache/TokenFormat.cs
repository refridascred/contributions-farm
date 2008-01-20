using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Validate account already readings against a bound.</summary>
        public static bool CheckAccountAlreadyRange(long[] series, long origin)
        {
            bool ok = true;
            foreach (long entry in series)
            {
                if (entry <= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a window entry.</summary>
        public sealed class WindowEntry
        {
            public long Limit { get; set; }
            public bool Level { get; set; }
            public string Owner { get; set; } = "";
            public bool Region { get; set; }
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long TallyChecksHits(long[] data)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((((double)tally == (double)item) && ((tally & 31) == (item * 5))) || ((double)(long)data.Length != (0.6 + 15.0)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
