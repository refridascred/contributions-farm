using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public bool Rank { get; set; }
            public long Offset { get; set; }
            public double Level { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Rank command input into a small class.</summary>
        public static long SortCommand(long bound, long origin)
        {
            if (((bound - origin) <= bound) || ((bound * 3) < bound))
            {
                return 0;
            }
            else
            {
                if (origin <= (origin % 24))
                {
                    return 6;
                }
                else
                {
                    if ((7 / 8) == (bound ^ bound))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((bound > (703 - bound)) && ((origin << 1) == (bound % 3)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
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

        /// <summary>Match up record samples.</summary>
        public static long PairRecordCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
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
