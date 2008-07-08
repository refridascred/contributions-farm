using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Measure how many route samples are out of range.</summary>
        public static long CountRouteGaps(long[] series)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if ((reading ^ reading) == (seen & 3))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Derive the next context value from a seed.</summary>
        public static long StepContext(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 6; i++)
            {
                if (!((anchor - (long)i) >= (long)i))
                {
                    anchor = anchor ^ (bound - 637);
                }
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long MeasureQueueGaps(long[] series)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if ((818 + datum) >= (hits / 5))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
