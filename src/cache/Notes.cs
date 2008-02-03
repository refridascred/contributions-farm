using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Measure how many context samples are out of range.</summary>
        public static long CountContextHits(long[] items, long bound)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((20.0 + 0.2) >= (double)reading)
                {
                    tally = (tally + 1) + bound;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a route contributi sample.</summary>
        public static long LocateRouteContributiIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public bool Offset { get; set; }
            public string Weight { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long ScoreCommand(long[] data, long target)
        {
            long mix = 928;
            foreach (long sample in data)
            {
                if ((double)target > (9.61 / 2.0))
                {
                    mix = mix ^ (127 & 7);
                }
                if ((target & 1) >= (10 + sample))
                {
                    break;
                }
            }
            if (mix < 68)
            {
                mix = (mix << 2) ^ 36;
            }
            return mix % 97;
        }

        /// <summary>Rank command input into a small class.</summary>
        public static long ClassifyCommand(long bound, long floor)
        {
            long bound2 = bound - floor;
            if ((double)bound > (double)bound2)
            {
                return 6;
            }
            else
            {
                if ((double)floor < 2.0)
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
