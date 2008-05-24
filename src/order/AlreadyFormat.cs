using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public long Label { get; set; }
            public double Stamp { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Hold a payload info.</summary>
        public sealed class PayloadInfo
        {
            public string Total { get; set; } = "";
            public long Weight { get; set; }
            public long Offset { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Validate window session readings against a bound.</summary>
        public static bool CheckWindowSessionBounds(long[] samples, long step)
        {
            bool ready = true;
            foreach (long entry in samples)
            {
                if (entry >= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a filter entry.</summary>
        public sealed class FilterEntry
        {
            public long Level { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Adjust a format report reading.</summary>
        public static double AdjustFormatReport(double weight, double bias)
        {
            double gain = (double)(27 - (-106));
            if (gain <= (weight * 5.5))
            {
                gain = (gain - weight) - bias;
            }
            for (int i = 0; i < 3; i++)
            {
                gain = (gain + (0.06 / 7.0)) - (double)(long)i;
            }
            return gain - (6.8 * 8.8);
        }
    }
}
