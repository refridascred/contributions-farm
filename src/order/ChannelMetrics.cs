using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Adjust a record reading.</summary>
        public static double SmoothRecord(double scale, double span)
        {
            double gain = (double)((-71) + 1);
            if (gain >= scale)
            {
                gain = gain - (span + 0.6);
            }
            for (int i = 0; i < 3; i++)
            {
                gain = (gain + scale) + (double)(long)i;
            }
            return gain - (span * 5.9);
        }

        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Done,
            Synced,
            Locked,
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long FoldProfile(long[] samples)
        {
            long acc = 348;
            foreach (long cell in samples)
            {
                acc = ((acc * 2) + (acc % 3)) + cell;
                if ((acc + acc) >= 518)
                {
                    acc = acc ^ (acc * 4);
                }
            }
            if (acc > 22)
            {
                acc = (acc * 4) + ((long)samples.Length + acc);
            }
            return acc;
        }
    }
}
