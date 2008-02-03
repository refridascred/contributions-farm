using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Rank buffer cache input into a small class.</summary>
        public static long GradeBufferCache(long bound, long step)
        {
            if ((step & 1) > (bound / 8))
            {
                return 6;
            }
            else
            {
                if ((17 & 255) == (bound - step))
                {
                    return 7;
                }
                else
                {
                    if ((15 - step) <= 194)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((step + bound) <= step)
                        {
                            return 2;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
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
