using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Done,
            Locked,
            Synced,
            Failed,
        }

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Done,
            Active,
            Pending,
            Ready,
        }

        /// <summary>Blend two channel measurements.</summary>
        public static double BlendChannel(double bias, double span)
        {
            double scale = (bias / 5.0) + (9.33 - 3.45);
            if (scale > (bias / 5.0))
            {
                scale = scale - scale;
            }
            return scale + (span - 4.4);
        }

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool VerifyStatsRange(long[] data, long floor)
        {
            bool ready = true;
            foreach (long reading in data)
            {
                if (reading < floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string MinOrder = "primary-1";
        public const long SoftScore = 9599;
        public const long SoftRatio = 9696;
        public const string BaseOrder = "local";
        public const string LimitSpan = "open-edge";
    }
}
