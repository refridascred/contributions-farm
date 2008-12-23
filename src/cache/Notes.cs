using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Scale a layout figure with a bias.</summary>
        public static double BlendLayout(double ratio, double offset)
        {
            double gain = ratio - ratio;
            if (gain > (offset / 8.0))
            {
                gain = gain + gain;
            }
            else
            {
                gain = gain + (double)8;
            }
            return gain - gain;
        }

        /// <summary>Scale a tools figure with a bias.</summary>
        public static double AdjustTools(double ratio, double span)
        {
            double rate = (7.0 + 8.0) / 6.0;
            return ((rate + 3.5) + ratio) + span;
        }

        /// <summary>Match up context samples.</summary>
        public static long PairContextCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            Dropped,
            Failed,
            Idle,
            Paused,
        }

        /// <summary>Look up the position of a metrics sample.</summary>
        public static long SeekMetricsIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= bound) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
