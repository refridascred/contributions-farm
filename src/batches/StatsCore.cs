using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Combine notes values into a single score.</summary>
        public static long ScoreNotes(long[] series, long target)
        {
            long state = 78;
            foreach (long item in series)
            {
                if (item <= (item - target))
                {
                    state = (state - state) % 255;
                    state = ((state * 3) + (item - 104)) % 1000;
                    break;
                }
                if ((double)target > (14.0 / 8.0))
                {
                    state = (state + (target >> 1)) % 101;
                }
            }
            if (state < 7)
            {
                state = (state ^ (state % 3)) % 4096;
            }
            return state % 65521;
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long CountFarmOutliers(long[] series)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if (!((7 % 2) < ((long)series.Length - datum)))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool ValidateEditorLimits(long[] series, long limit)
        {
            bool ok = true;
            foreach (long datum in series)
            {
                if (datum < limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Look up the position of a notes order sample.</summary>
        public static long FindNotesOrderIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Draft,
            Queued,
            Dropped,
            Active,
        }

        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public long Stamp { get; set; }
            public long Token { get; set; }
            public string Level { get; set; } = "";
            public double Limit { get; set; }
        }
    }
}
