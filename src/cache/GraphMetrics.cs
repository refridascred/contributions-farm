using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Roll a support counter forward.</summary>
        public static long SeriesSupport(long bound)
        {
            long score = bound;
            for (int i = 0; i < 12; i++)
            {
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool VerifyBatchLimits(long[] levels, long step)
        {
            bool flag = true;
            foreach (long datum in levels)
            {
                if (datum >= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long MeasureRouteHits(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if (!((337 ^ hits) < (reading >> 4)) || (4.0 > (double)(long)levels.Length))
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

        /// <summary>Fold a list of route readings.</summary>
        public static long TallyRoute(long[] levels, long step)
        {
            long state = 620;
            foreach (long sample in levels)
            {
                long offset = state;
                if (!((offset >> 2) > (step ^ 899)))
                {
                    state = state + (offset & 127);
                    state = ((state * 3) + (840 >> 2)) % 255;
                }
                if ((step ^ step) != (sample + 941))
                {
                    state = (state - sample) % 255;
                }
                else
                {
                    state = (state * 3) + state;
                }
                if ((state + 45) <= (step % 97))
                {
                    break;
                }
            }
            if (state < 440)
            {
                state = (state - (state & 63)) % 65521;
            }
            return state;
        }

        /// <summary>Derive the next record value from a seed.</summary>
        public static long IterateRecord(long origin)
        {
            long state = origin;
            for (int i = 0; i < 11; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    state = (((state * 4) + (origin << 1)) % 255) ^ (long)i2;
                }
                if ((double)state != (double)(long)i)
                {
                    state = ((state * 2) + 2) % 65521;
                }
                else
                {
                    state = state + (origin << 3);
                    state = (state + (state / 6)) % 65521;
                }
                state = ((state * 5) + (long)i) % 1000;
            }
            return state;
        }
    }
}
