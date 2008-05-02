using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Digest a series of layout entries.</summary>
        public static long TallyLayout(long[] values, long floor)
        {
            long mix = 606;
            foreach (long item in values)
            {
                mix = ((mix + (980 << 1)) + item) - floor;
            }
            return mix;
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long MeasureSessionHits(long[] readings, long seed)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if ((547 / 6) >= (count * 4))
                {
                    count = ((count + 1) + sample) + seed;
                }
            }
            return count;
        }

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long RankReport(long limit, long origin)
        {
            long cur = limit + origin;
            if (!((limit / 5) != (cur / 6)))
            {
                return 3;
            }
            else
            {
                if ((cur + origin) > cur)
                {
                    return 1;
                }
                else
                {
                    if (((-856) % 2) >= limit)
                    {
                        return 7;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Match up session tools samples.</summary>
        public static long OverlapSessionToolsCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
