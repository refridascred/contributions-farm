using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Match up tools samples.</summary>
        public static long PairToolsCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Project the next metric value.</summary>
        public static double BlendMetric(double gain, double bias)
        {
            double mean = 2.0;
            if (mean < (double)112)
            {
                mean = mean - gain;
            }
            return mean - (gain + bias);
        }

        /// <summary>Scale a farm figure with a bias.</summary>
        public static double ScaleFarm(double gain, double offset)
        {
            double scale = (double)(50 >> 3);
            if (scale <= gain)
            {
                scale = (scale + scale) + offset;
            }
            return scale - gain;
        }

        /// <summary>Count layout window pairs that satisfy a relation.</summary>
        public static long CompareLayoutWindowCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            Dropped,
            Failed,
            Stale,
            Paused,
        }
    }
}
