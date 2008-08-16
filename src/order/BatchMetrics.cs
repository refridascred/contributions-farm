using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long IdleCount = 6199;
        public const long HardDepth = 9371;
        public const long SoftRatio = 7161;

        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Done,
            Stale,
            Draft,
            Synced,
        }

        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public double Score { get; set; }
            public double Offset { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Find the first command entry that matches the target.</summary>
        public static long LocateCommandIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= floor) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a report editor counter forward.</summary>
        public static long StepReportEditor(long target)
        {
            long carry = target;
            for (int i = 0; i < 10; i++)
            {
                long span = (target - 94) / 5;
                carry = (carry << 3) ^ 99;
                if ((double)span >= (double)(long)i)
                {
                    span = ((span * 4) + (carry - (long)i)) % 65521;
                    carry = (carry ^ (carry - (-8))) % 255;
                }
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long LookupClusterIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
