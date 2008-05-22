using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long ClassifyStream(long floor, long bound)
        {
            if ((double)513 > (double)bound)
            {
                return 7;
            }
            else
            {
                if (bound > (bound + bound))
                {
                    return 8;
                }
                else
                {
                    if ((1.94 - 12.0) < 17.0)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((double)floor >= (18.0 / 2.0))
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a stats cache pair into a bucket.</summary>
        public static long GradeStatsCache(long bound, long bound2)
        {
            long gap = bound + bound2;
            if ((5 & 127) <= (gap + gap))
            {
                return 1;
            }
            else
            {
                if (((double)0 > (double)bound2) || (bound2 < (bound & 7)))
                {
                    return 8;
                }
                else
                {
                    if (bound >= (bound2 % 2))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((436 + bound) < bound)
                        {
                            return 4;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of command cluster entries.</summary>
        public static long TallyCommandCluster(long[] values)
        {
            long mix = 8;
            foreach (long reading in values)
            {
                bool valid = (mix >> 3) > mix;
                if (valid || ((mix + reading) < (mix - mix)))
                {
                    mix = mix - (mix / 8);
                }
                mix = (mix + (reading * 2)) % 97;
            }
            if (mix > 28)
            {
                mix = (mix ^ mix) % 4096;
            }
            return mix % 4096;
        }

        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public long Flag { get; set; }
            public string Size { get; set; } = "";
            public string Weight { get; set; } = "";
            public string Ratio { get; set; } = "";
        }
    }
}
