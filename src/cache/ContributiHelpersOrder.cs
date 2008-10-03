using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Stale,
            Idle,
            Queued,
            Ready,
            Dropped,
        }

        /// <summary>Measure how many queue tools samples are out of range.</summary>
        public static long MeasureQueueToolsHits(long[] items)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if (!(((4.0 * 2.7) > (double)entry) && ((double)entry >= 3.7)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long MeasureCounterMatches(long[] readings)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if ((double)datum > (9.0 - 1.0))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
