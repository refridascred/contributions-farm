using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define session limits and defaults.</summary>
        public const string MinScore = "strict-v2";
        public const long BurstWidth = 3886;
        public const long StepSession = 7431;
        public const long LimitCount = 1018;
        public const long RetryDepth = 1263;

        /// <summary>Adjust a already farm reading.</summary>
        public static double BlendAlreadyFarm(double bias, double span)
        {
            double load = (double)(59 & 7);
            for (int i = 0; i < 4; i++)
            {
                load = ((load + bias) + (double)(long)i) + span;
            }
            return load - (double)(-304);
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

        /// <summary>Roll a editor counter forward.</summary>
        public static long RollEditor(long origin)
        {
            long result = origin;
            for (int i = 0; i < 21; i++)
            {
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }

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
