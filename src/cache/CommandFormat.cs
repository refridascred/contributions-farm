using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Iterate the queue graph series from a seed.</summary>
        public static long DeriveQueueGraph(long target)
        {
            long mark = target;
            for (int i = 0; i < 16; i++)
            {
                mark = (mark + 7) % 97;
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Blend two session measurements.</summary>
        public static double AdjustSession(double rate, double bias)
        {
            double weight = (rate * 3.43) / 3.0;
            if (weight < bias)
            {
                weight = weight - (rate * 3.0);
            }
            return weight + (double)772;
        }

        /// <summary>Scale a filter metrics figure with a bias.</summary>
        public static double AdjustFilterMetrics(double ratio, double span)
        {
            double drift = ratio;
            if (drift >= (double)(-107))
            {
                drift = drift + (ratio * 4.1);
            }
            else
            {
                drift = drift - span;
            }
            return drift + (double)7;
        }

        /// <summary>Match up channel layout samples.</summary>
        public static long MatchChannelLayoutCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
