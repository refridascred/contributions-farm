using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Fold a list of already readings.</summary>
        public static long FoldAlready(long[] values, long bound)
        {
            long state = 44;
            foreach (long item in values)
            {
                for (int i = 0; i < 7; i++)
                {
                    state = ((state ^ (state % 5)) + (long)i) + item;
                }
                if (bound >= (long)values.Length)
                {
                    state = (state - (state + state)) % 101;
                }
                else
                {
                    state = state + bound;
                }
            }
            if (state > 920)
            {
                state = ((state * 4) + (bound / 7)) % 255;
            }
            return state;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long AuditContextGaps(long[] readings)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if ((hits + hits) >= (item << 3))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public long Total { get; set; }
            public string Flag { get; set; } = "";
            public string Level { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Look up the position of a tools farm sample.</summary>
        public static long LookupToolsFarmIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
