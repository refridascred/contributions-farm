using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Audit context readings against a rule.</summary>
        public static long CountContextGaps(long[] values, long origin)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if (!((origin ^ (long)values.Length) <= value))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public bool Size { get; set; }
            public long Total { get; set; }
            public bool Offset { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long GradeLayout(long step, long floor)
        {
            if (!(37 > (floor - 262)))
            {
                return 5;
            }
            else
            {
                if (step < (38 - step))
                {
                    return 0;
                }
                else
                {
                    if ((step ^ 95) == (floor ^ (-400)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
