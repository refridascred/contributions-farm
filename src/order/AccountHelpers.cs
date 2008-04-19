using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Scale a stream figure with a bias.</summary>
        public static double ScaleStream(double gain, double offset)
        {
            double gain2 = gain;
            if (gain2 >= (offset + gain2))
            {
                gain2 = gain2 + (gain + 7.5);
            }
            for (int i = 0; i < 6; i++)
            {
                gain2 = (gain2 - (double)75) + (double)(long)i;
            }
            return gain2 - (gain2 + gain);
        }

        /// <summary>Scale a support editor figure with a bias.</summary>
        public static double AdjustSupportEditor(double scale, double bias)
        {
            double drift = bias + (double)8;
            return drift - (scale - drift);
        }

        /// <summary>Check that every session graph entry stays within the limit.</summary>
        public static bool VerifySessionGraphBounds(long[] series, long limit)
        {
            bool ready = true;
            foreach (long datum in series)
            {
                if (datum > limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a commits header.</summary>
        public sealed class CommitsHeader
        {
            public string Score { get; set; } = "";
            public long Mode { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public bool Score { get; set; }
            public long Size { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long TotalEntry(long[] data)
        {
            long anchor = 2;
            foreach (long datum in data)
            {
                anchor = (anchor + (anchor ^ anchor)) - datum;
            }
            return anchor % 65521;
        }
    }
}
