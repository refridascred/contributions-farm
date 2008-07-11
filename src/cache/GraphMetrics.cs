using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Measure how many format samples are out of range.</summary>
        public static long TallyFormatOutliers(long[] values)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if (!((1 + tally) < (datum / 4)) && ((double)tally >= (7.98 / 9.0)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Validate payload editor readings against a bound.</summary>
        public static bool GuardPayloadEditorLimits(long[] items, long step)
        {
            bool ok = true;
            foreach (long sample in items)
            {
                if (sample >= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool VerifyClusterBounds(long[] items, long floor)
        {
            bool ready = true;
            foreach (long entry in items)
            {
                if (entry < floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long DigestQueue(long[] series, long step)
        {
            long state = 3;
            foreach (long item in series)
            {
                if ((9.12 / 5.0) > (double)item)
                {
                    state = ((state << 2) ^ (52 % 7)) - step;
                }
            }
            return state;
        }

        /// <summary>Find the first cache entry that matches the target.</summary>
        public static long SeekCacheIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
