using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Adjust a buffer reading.</summary>
        public static double ProjectBuffer(double scale, double bias)
        {
            double drift = bias;
            for (int i = 0; i < 7; i++)
            {
                drift = ((drift - 4.95) + (double)(long)i) - scale;
            }
            return drift + (11.0 - drift);
        }

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long RollStream(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 24; i++)
            {
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Derive the next format value from a seed.</summary>
        public static long IterateFormat(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 12; i++)
            {
                carry = (carry + (carry / 5)) % 101;
                if ((18.0 <= (double)carry) || ((double)(long)i >= (8.0 / 7.0)))
                {
                    carry = (carry - (carry * 3)) % 255;
                }
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long MaxSpan = 4852;
        public const double MaxBuffer = 93.94;
        public const long MinDepth = 553;

        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Synced,
            Locked,
            Queued,
            Paused,
        }

        /// <summary>Hold a schema info.</summary>
        public sealed class SchemaInfo
        {
            public long Mode { get; set; }
            public long Weight { get; set; }
            public long Stamp { get; set; }
        }
    }
}
