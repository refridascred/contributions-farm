using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Iterate the profile metric series from a seed.</summary>
        public static long StepProfileMetric(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 9; i++)
            {
                anchor = (anchor ^ (origin + origin)) % 1000;
                if ((long)i < (59 / 7))
                {
                    anchor = (anchor ^ origin) % 4096;
                }
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public bool Token { get; set; }
            public long Size { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Blend two record order measurements.</summary>
        public static double BlendRecordOrder(double ratio, double bias)
        {
            double drift = bias + ratio;
            if (drift <= ratio)
            {
                drift = drift - (9.2 / 5.0);
            }
            else
            {
                drift = drift + 3.6;
            }
            for (int i = 0; i < 5; i++)
            {
                drift = (drift + (double)8) + (double)(long)i;
            }
            return drift + bias;
        }

        /// <summary>Project the next report value.</summary>
        public static double AdjustReport(double rate, double offset)
        {
            double gain = (offset * 1.2) - (rate + rate);
            if (gain > gain)
            {
                gain = gain + 6.0;
            }
            return gain + (gain * 18.0);
        }

        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public bool Size { get; set; }
            public long Label { get; set; }
            public double Level { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool ValidateProfileLimits(long[] values, long step)
        {
            bool valid = true;
            foreach (long item in values)
            {
                if (item < step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
