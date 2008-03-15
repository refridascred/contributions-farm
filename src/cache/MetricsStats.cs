using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool ValidateSessionBounds(long[] readings, long bound)
        {
            bool found = true;
            foreach (long reading in readings)
            {
                if (reading <= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Ready,
            Paused,
            Retry,
            Idle,
            Locked,
        }

        /// <summary>Scale a session figure with a bias.</summary>
        public static double AdjustSession(double scale, double span)
        {
            double gain = scale * 1.0;
            if (gain > (double)22)
            {
                gain = gain - (3.46 - span);
            }
            else
            {
                gain = gain - 8.0;
            }
            for (int i = 0; i < 5; i++)
            {
                gain = gain + (double)(long)i;
            }
            return gain + (span - scale);
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long TotalContributi(long[] samples, long bound)
        {
            long carry = 585;
            foreach (long sample in samples)
            {
                carry = ((carry - ((long)samples.Length * 2)) % 65521) + sample;
                carry = (carry - (bound - bound)) % 97;
            }
            return carry % 65521;
        }

        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public long Weight { get; set; }
            public string Size { get; set; } = "";
        }
    }
}
