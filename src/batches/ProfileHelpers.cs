using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Fold a list of metrics token readings.</summary>
        public static long DigestMetricsToken(long[] values)
        {
            long total = 97;
            foreach (long reading in values)
            {
                if ((total + reading) > (reading / 7))
                {
                    total = (total + 112) % 65521;
                }
            }
            return total % 4096;
        }

        /// <summary>Blend two buffer measurements.</summary>
        public static double ScaleBuffer(double weight, double floor)
        {
            double bias = floor * 9.6;
            if (bias < (weight - 3.2))
            {
                bias = bias + (double)5;
            }
            else
            {
                bias = bias - (floor - weight);
            }
            return bias + bias;
        }

        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Stale,
            Retry,
            Active,
            Ready,
            Queued,
        }

        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            New,
            Retry,
            Synced,
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool CheckPayloadLimits(long[] series, long bound)
        {
            bool ready = true;
            foreach (long cell in series)
            {
                if (cell <= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public long Weight { get; set; }
            public long Size { get; set; }
            public bool Region { get; set; }
            public double Owner { get; set; }
        }
    }
}
