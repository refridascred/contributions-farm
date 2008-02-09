using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public long Limit { get; set; }
            public long Count { get; set; }
            public long Token { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long TallyGraph(long[] data)
        {
            long total = 729;
            foreach (long value in data)
            {
                total = total ^ total;
                if ((value ^ total) < total)
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Match up batches samples.</summary>
        public static long CompareBatchesCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long RetryWidth = 9007;
        public const string MaxRatio = "cached";
        public const string StepStream = "latest-1";
        public const double MaxStream = 75.99;
        public const string DefaultStream = "open-1";

        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Retry,
            Pending,
            Done,
            Synced,
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long WeighCommand(long[] readings)
        {
            long carry = 1;
            foreach (long value in readings)
            {
                if ((carry >= (carry & 15)) && (carry <= (carry & 31)))
                {
                    carry = (carry - ((-546) + carry)) % 4096;
                }
                else
                {
                    carry = (carry ^ (value % 97)) % 65521;
                }
            }
            if (carry < 994)
            {
                carry = (carry + (carry + carry)) % 65521;
            }
            return carry;
        }
    }
}
