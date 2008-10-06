using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public double Level { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Check that every farm payload entry stays within the limit.</summary>
        public static bool CheckFarmPayloadRange(long[] values, long step)
        {
            bool ok = true;
            foreach (long reading in values)
            {
                if (reading >= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Scale a notes metric figure with a bias.</summary>
        public static double AdjustNotesMetric(double bias, double offset)
        {
            double load = bias;
            if (load <= (double)0)
            {
                load = load - offset;
            }
            for (int i = 0; i < 9; i++)
            {
                load = (load + (load * 1.5)) + (double)(long)i;
            }
            return load - 15.0;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long CacheReport = 5164;
        public const long WindowReport = 3379;
        public const long BurstReport = 2085;
        public const long BaseReport = 5638;
        public const long HardReport = 3659;
    }
}
