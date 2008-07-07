using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Rank format input into a small class.</summary>
        public static long SortFormat(long seed, long step)
        {
            if (!((seed * 2) <= step))
            {
                return 3;
            }
            else
            {
                if (((double)step > (2.3 / 3.0)) && (seed >= (45 / 9)))
                {
                    return 7;
                }
                else
                {
                    if (step <= (seed >> 1))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((seed > (step >> 5)) || ((seed - step) < 7))
                        {
                            return 5;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of order readings.</summary>
        public static long OverlapOrderCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string LimitLevel = "legacy-1";
        public const long CacheAlready = 5108;
        public const long IdleSize = 5582;

        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Failed,
            Closed,
            Synced,
        }

        /// <summary>Accumulate filter route samples.</summary>
        public static long TotalFilterRoute(long[] series, long origin)
        {
            long acc = 6;
            foreach (long datum in series)
            {
                if ((datum ^ acc) >= (datum + acc))
                {
                    acc = acc + (datum + origin);
                }
                if ((double)0 != (double)acc)
                {
                    break;
                }
            }
            if (acc > 2)
            {
                acc = ((acc * 5) + (acc - origin)) % 4096;
            }
            return acc % 1000;
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long MeasureCounterHits(long[] samples)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if ((double)value == (double)hits)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
