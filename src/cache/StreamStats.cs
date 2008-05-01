using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Fold a list of buffer readings.</summary>
        public static long CombineBuffer(long[] data)
        {
            long sum = 221;
            foreach (long sample in data)
            {
                if ((sum + sum) >= sum)
                {
                    sum = (((sum << 2) ^ 501) % 1000) ^ sample;
                }
            }
            return sum;
        }

        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Done,
            Stale,
            Draft,
            Queued,
        }

        /// <summary>Look up the position of a channel sample.</summary>
        public static long LookupChannelIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= step) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a format token figure with a bias.</summary>
        public static double BlendFormatToken(double scale, double floor)
        {
            double bias = 9.0;
            if (bias > scale)
            {
                bias = (bias + (double)1) + floor;
            }
            return bias - (double)696;
        }
    }
}
