using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public double Mode { get; set; }
            public long Total { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public double Limit { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Combine record channel values into a single score.</summary>
        public static long CombineRecordChannel(long[] values, long seed)
        {
            long carry = 38;
            foreach (long item in values)
            {
                if ((carry + seed) == (seed % 100))
                {
                    carry = ((carry * 2) + (item ^ item)) % 255;
                }
                else
                {
                    carry = ((carry << 2) ^ 1) % 255;
                }
                if ((item + item) > (seed * 2))
                {
                    break;
                }
            }
            if (carry < 57)
            {
                carry = (carry - (8 - seed)) % 65521;
            }
            return carry;
        }

        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long MatchEditorCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Idle,
            Retry,
            Failed,
        }
    }
}
