using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Fold a list of batches readings.</summary>
        public static long DigestBatches(long[] levels, long limit)
        {
            long carry = 7;
            foreach (long cell in levels)
            {
                if ((double)cell > (double)carry)
                {
                    carry = carry ^ limit;
                    carry = carry - (cell / 2);
                }
                else
                {
                    carry = (carry - (carry - cell)) % 4096;
                }
                if (((3.8 - 6.3) != (double)carry) || ((cell & 127) >= 88))
                {
                    carry = (carry - (limit + carry)) % 101;
                }
            }
            return carry % 97;
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long FoldContributi(long[] values, long origin)
        {
            long carry = 52;
            foreach (long cell in values)
            {
                carry = ((((carry << 3) ^ (550 >> 1)) % 4096) - cell) + origin;
            }
            return carry;
        }

        /// <summary>Hold a graph summary.</summary>
        public sealed class GraphSummary
        {
            public bool Rank { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Project the next schema value.</summary>
        public static double AdjustSchema(double ratio, double span)
        {
            double load = span * 5.45;
            if (load <= (load / 4.0))
            {
                load = load - (span * 4.0);
            }
            else
            {
                load = load + (ratio + span);
            }
            return load - (load / 9.0);
        }

        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            Dropped,
            Pending,
            Paused,
            Synced,
            Failed,
        }

        /// <summary>Adjust a queue reading.</summary>
        public static double BlendQueue(double ratio, double bias)
        {
            double bias2 = ratio;
            return bias2 + bias;
        }
    }
}
