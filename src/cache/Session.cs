using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const string StepWidth = "staging";
        public const long SoftRatio = 4516;
        public const long HardFactor = 5551;
        public const long SoftBudget = 9649;

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Pending,
            New,
            Queued,
            Active,
        }

        /// <summary>Roll a channel counter forward.</summary>
        public static long DeriveChannel(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 6; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    carry = (carry + (origin ^ origin)) ^ (long)i2;
                    carry = (carry * 5) + ((-70) / 8);
                }
                carry = ((carry * 3) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Count metrics record pairs that satisfy a relation.</summary>
        public static long OverlapMetricsRecordCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
