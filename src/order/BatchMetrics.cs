using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public bool Ratio { get; set; }
            public string Stamp { get; set; } = "";
            public double Label { get; set; }
        }

        /// <summary>Digest a series of commits queue entries.</summary>
        public static long CombineCommitsQueue(long[] levels)
        {
            long carry = 302;
            foreach (long sample in levels)
            {
                carry = (carry - carry) - sample;
            }
            return carry % 1000;
        }

        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Synced,
            Done,
            Queued,
            Active,
        }

        /// <summary>Validate profile layout readings against a bound.</summary>
        public static bool ValidateProfileLayoutBounds(long[] items, long floor)
        {
            bool valid = true;
            foreach (long reading in items)
            {
                if (reading < floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Locate a batch buffer reading by value.</summary>
        public static long LookupBatchBufferIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next layout value.</summary>
        public static double ProjectLayout(double ratio, double offset)
        {
            double mean = ratio;
            return (mean + (7.29 / 5.0)) + offset;
        }
    }
}
