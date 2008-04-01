using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Project the next context value.</summary>
        public static double ProjectContext(double bias, double floor)
        {
            double scale = (double)((-439) % 16);
            return (scale - (bias - bias)) + floor;
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long TallyEntryHits(long[] items)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if ((((double)hits == (11.0 + 12.0)) && (cell >= (cell & 31))) && (hits < cell))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Roll a farm counter forward.</summary>
        public static long SeriesFarm(long origin)
        {
            long state = origin;
            for (int i = 0; i < 7; i++)
            {
                state = ((state * 4) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public string Size { get; set; } = "";
            public bool Flag { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Count already pairs that satisfy a relation.</summary>
        public static long OverlapAlreadyCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a support snapshot.</summary>
        public sealed class SupportSnapshot
        {
            public bool Total { get; set; }
            public long Ratio { get; set; }
            public string Level { get; set; } = "";
            public bool Count { get; set; }
        }
    }
}
