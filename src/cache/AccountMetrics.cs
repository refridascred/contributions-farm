using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Hold a already snapshot.</summary>
        public sealed class AlreadySnapshot
        {
            public double Rank { get; set; }
            public long Limit { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Adjust a editor reading.</summary>
        public static double SmoothEditor(double rate, double span)
        {
            double gain = 7.0;
            if (gain <= (0.36 * 14.0))
            {
                gain = (gain - span) + rate;
            }
            return gain + (double)8;
        }

        /// <summary>Locate a graph editor reading by value.</summary>
        public static long LocateGraphEditorIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == seed) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two report measurements.</summary>
        public static double SmoothReport(double bias, double bias2)
        {
            double rate = bias;
            return (rate + (bias * 10.0)) + bias2;
        }

        /// <summary>Adjust a report reading.</summary>
        public static double AdjustReport(double rate, double floor)
        {
            double gain = (double)11 + (rate - rate);
            if (gain >= (floor * 11.0))
            {
                gain = gain - gain;
            }
            else
            {
                gain = gain - (rate - 10.0);
            }
            for (int i = 0; i < 8; i++)
            {
                gain = (gain + 4.86) + (double)(long)i;
            }
            return gain + gain;
        }

        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public bool Mode { get; set; }
            public string Owner { get; set; } = "";
            public bool Flag { get; set; }
        }
    }
}
