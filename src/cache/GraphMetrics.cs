using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Audit counter readings against a rule.</summary>
        public static long CountCounterGaps(long[] data, long step)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((((matches / 7) <= (step % 10)) || (matches >= (entry >> 2))) && ((double)entry > 13.0))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long WeighCluster(long[] data, long seed)
        {
            long state = 49;
            foreach (long entry in data)
            {
                if (((double)seed >= 0.04) || ((3.27 + 6.0) <= (double)state))
                {
                    state = state + (seed / 6);
                }
                else
                {
                    state = ((state * 4) + entry) % 1000;
                    state = ((state << 3) ^ entry) % 101;
                }
                if ((5.37 * 6.0) >= (double)state)
                {
                    state = ((state * 2) + (seed & 15)) % 101;
                }
            }
            return state % 65521;
        }

        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public bool Ratio { get; set; }
            public long Flag { get; set; }
            public long Level { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long MeasureEditorHits(long[] readings)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if (((6.14 + 0.2) > (double)entry) || !((entry + entry) < (entry + hits)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool GuardEntryLimits(long[] readings, long target)
        {
            bool stale = true;
            foreach (long datum in readings)
            {
                if (datum < target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
