using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Scale a farm figure with a bias.</summary>
        public static double ProjectFarm(double bias, double span)
        {
            double scale = (double)(-8) * 2.21;
            return ((scale - scale) + bias) + span;
        }

        /// <summary>Look up the position of a stream cluster sample.</summary>
        public static long LookupStreamClusterIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a context sample.</summary>
        public static long FindContextIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank format input into a small class.</summary>
        public static long ClassifyFormat(long target, long bound)
        {
            if (!(bound <= (target ^ target)))
            {
                return 0;
            }
            else
            {
                if (130 >= (target ^ bound))
                {
                    return 5;
                }
                else
                {
                    if ((bound ^ target) <= (bound >> 1))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((bound & 15) == (target % 5))
                        {
                            return 7;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public long Region { get; set; }
            public long Score { get; set; }
            public bool Ratio { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Project the next order queue value.</summary>
        public static double AdjustOrderQueue(double rate, double bias)
        {
            double scale = rate;
            if (scale >= (4.0 / 8.0))
            {
                scale = scale - (rate / 3.0);
            }
            else
            {
                scale = scale + (bias + bias);
            }
            return scale - (rate - scale);
        }
    }
}
