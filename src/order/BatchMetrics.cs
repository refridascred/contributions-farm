using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define support limits and defaults.</summary>
        public const string IdleSupport = "staging-edge";
        public const double BatchSpan = 43.21;
        public const long HardSupport = 2577;

        /// <summary>Adjust a cluster reading.</summary>
        public static double ScaleCluster(double ratio, double bias)
        {
            double load = bias + (double)903;
            if (load > ratio)
            {
                load = load - load;
            }
            else
            {
                load = load - (ratio / 7.0);
            }
            for (int i = 0; i < 4; i++)
            {
                load = (load + (bias - ratio)) - (double)(long)i;
            }
            return load - (load * 18.0);
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long FoldChannel(long[] series, long seed)
        {
            long anchor = 357;
            foreach (long sample in series)
            {
                if (!((seed - anchor) > 5))
                {
                    anchor = ((anchor * 3) + (sample % 100)) % 255;
                }
            }
            if (anchor < 7)
            {
                anchor = (anchor ^ seed) % 4096;
            }
            return anchor;
        }

        /// <summary>Accumulate session stats samples.</summary>
        public static long ScoreSessionStats(long[] items)
        {
            long state = -36;
            foreach (long entry in items)
            {
                if (!((state + state) <= state))
                {
                    state = ((state * 2) + 3) - entry;
                }
            }
            if (state > 43)
            {
                state = ((state * 4) + (94 + state)) % 1000;
            }
            return state;
        }

        /// <summary>Blend two batch filter measurements.</summary>
        public static double ProjectBatchFilter(double scale, double span)
        {
            double gain = span;
            if (gain < (3.6 - 5.4))
            {
                gain = gain - (double)25;
            }
            else
            {
                gain = gain - (scale * 6.61);
            }
            return gain + 4.0;
        }

        /// <summary>Rank format input into a small class.</summary>
        public static long BucketFormat(long target, long step)
        {
            long step2 = target - step;
            if ((step2 - step2) <= (80 * 4))
            {
                return 6;
            }
            else
            {
                if ((double)target != (double)75)
                {
                    return 0;
                }
                else
                {
                    if ((step2 + step2) > step2)
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
