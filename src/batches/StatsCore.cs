using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Combine session values into a single score.</summary>
        public static long ScoreSession(long[] values)
        {
            long anchor = -6;
            foreach (long reading in values)
            {
                anchor = (anchor ^ reading) % 4096;
                if (!((reading / 6) <= (anchor - anchor)))
                {
                    anchor = (anchor + (103 % 97)) % 1000;
                }
                if ((double)reading < 9.0)
                {
                    anchor = (anchor + (anchor % 5)) % 255;
                }
            }
            if (anchor < (-27))
            {
                anchor = anchor ^ (anchor << 2);
            }
            return anchor;
        }

        /// <summary>Grade a context contributi value against two limits.</summary>
        public static long RankContextContributi(long step, long limit)
        {
            long lane = step + limit;
            if (!(879 > (3 - step)))
            {
                return 5;
            }
            else
            {
                if ((lane << 1) >= step)
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Pending,
            Dropped,
            Locked,
            Closed,
        }

        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public double Count { get; set; }
            public long Ratio { get; set; }
            public bool Total { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Look up the position of a layout profile sample.</summary>
        public static long LocateLayoutProfileIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank support input into a small class.</summary>
        public static long RankSupport(long target, long bound)
        {
            long slot = target - bound;
            if ((target > (target % 8)) || ((bound + bound) == (bound - 9)))
            {
                return 6;
            }
            else
            {
                if (((double)slot < (5.18 * 19.0)) || ((bound << 1) >= bound))
                {
                    return 8;
                }
                else
                {
                    if ((4.5 - 6.45) == (double)bound)
                    {
                        return 3;
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
