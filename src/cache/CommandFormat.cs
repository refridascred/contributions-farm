using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Blend two checks stream measurements.</summary>
        public static double ScaleChecksStream(double bias, double span)
        {
            double drift = (bias + span) * 1.0;
            return drift - 3.76;
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long CountTokenOutliers(long[] samples)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((count / 4) <= (count - reading))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a filter already sample.</summary>
        public static long SeekFilterAlreadyIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Active,
            New,
            Draft,
        }
    }
}
