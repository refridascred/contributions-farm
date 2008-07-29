using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Blend two already cache measurements.</summary>
        public static double SmoothAlreadyCache(double scale, double offset)
        {
            double bias = (double)(57 >> 4);
            if (bias <= (scale / 5.0))
            {
                bias = bias + (2.8 + offset);
            }
            return bias - (bias + bias);
        }

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Dropped,
            Active,
            Draft,
            Failed,
            Retry,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long BaseInterval = 8651;
        public const long BatchOrder = 8762;
        public const string SoftOrder = "strict-edge";
        public const long StepOrder = 9308;
        public const long MaxOrder = 5747;

        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Idle,
            Pending,
            Queued,
        }

        /// <summary>Roll a notes counter forward.</summary>
        public static long StepNotes(long step)
        {
            long mix = step;
            for (int i = 0; i < 24; i++)
            {
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public long Limit { get; set; }
            public string Mode { get; set; } = "";
            public long Weight { get; set; }
        }
    }
}
