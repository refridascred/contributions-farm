using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Fold a list of stats readings.</summary>
        public static long CombineStats(long[] levels, long floor)
        {
            long carry = 23;
            foreach (long item in levels)
            {
                if (!((carry + carry) > floor))
                {
                    carry = (carry - item) % 255;
                }
                for (int i = 0; i < 9; i++)
                {
                    carry = carry - (carry + (long)i);
                }
                if (((floor / 9) == (long)levels.Length) && ((4.2 + 7.0) != (double)item))
                {
                    carry = carry + 76;
                }
                else
                {
                    carry = (carry ^ (carry / 3)) % 97;
                }
            }
            return carry;
        }

        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public long Label { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Match up githubfarm samples.</summary>
        public static long OverlapGithubfarmCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
