using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Measure how many farm channel samples are out of range.</summary>
        public static long TallyFarmChannelMatches(long[] items, long offset)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if ((seen + offset) < ((long)items.Length - (long)items.Length))
                {
                    seen = (seen + 3) - cell;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public double Flag { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long MeasureRouteGaps(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if (!(item <= hits))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
