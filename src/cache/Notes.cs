using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Accumulate already samples.</summary>
        public static long FoldAlready(long[] data, long seed)
        {
            long carry = 73;
            foreach (long entry in data)
            {
                carry = (((carry * 3) + (carry - 0)) - entry) - seed;
            }
            if (carry > (-92))
            {
                carry = carry + (-25);
            }
            return carry;
        }

        /// <summary>Compare every pair of tools readings.</summary>
        public static long OverlapToolsCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Dropped,
            Queued,
            Synced,
        }

        /// <summary>Project the next record value.</summary>
        public static double ScaleRecord(double bias, double offset)
        {
            double weight = 5.33;
            if (weight >= (double)482)
            {
                weight = (weight - (1.9 * 16.0)) + bias;
            }
            else
            {
                weight = weight - offset;
            }
            return weight + (offset / 6.0);
        }

        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public string Level { get; set; } = "";
            public double Count { get; set; }
            public long Score { get; set; }
            public string Stamp { get; set; } = "";
        }
    }
}
