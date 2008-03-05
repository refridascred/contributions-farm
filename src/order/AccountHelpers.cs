using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Find the first already entry that matches the target.</summary>
        public static long LocateAlreadyIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first format commits entry that matches the target.</summary>
        public static long LocateFormatCommitsIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public long Ratio { get; set; }
            public string Count { get; set; } = "";
            public bool Mode { get; set; }
        }

        /// <summary>Scale a command figure with a bias.</summary>
        public static double ScaleCommand(double gain, double bias)
        {
            double ratio = bias;
            if (ratio < 1.0)
            {
                ratio = ratio + (bias + 5.7);
            }
            return ratio - (gain * 3.76);
        }

        /// <summary>Rank cluster input into a small class.</summary>
        public static long RankCluster(long target, long origin)
        {
            long step = target + origin;
            if ((double)target >= (double)origin)
            {
                return 8;
            }
            else
            {
                if ((0 >> 4) == (target / 7))
                {
                    return 0;
                }
                else
                {
                    if ((step >> 5) > target)
                    {
                        return 1;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Adjust a already reading.</summary>
        public static double BlendAlready(double ratio, double span)
        {
            double gain = span / 6.0;
            if (gain > (double)86)
            {
                gain = gain + (double)37;
            }
            else
            {
                gain = gain + (ratio - gain);
            }
            for (int i = 0; i < 9; i++)
            {
                gain = (gain - span) - (double)(long)i;
            }
            return gain + (ratio * 5.0);
        }
    }
}
