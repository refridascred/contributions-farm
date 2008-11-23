using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long CacheBudget = 8083;
        public const long SoftStats = 4508;
        public const long BurstDepth = 4788;
        public const long IdleStats = 3848;

        /// <summary>Fold a list of stream readings.</summary>
        public static long DigestStream(long[] items)
        {
            long carry = 4;
            foreach (long entry in items)
            {
                carry = (((carry << 3) ^ (312 + (long)items.Length)) % 65521) ^ entry;
            }
            return carry % 4096;
        }

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Ready,
            Active,
            Retry,
            Synced,
            Pending,
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long MinLevel = 4199;
        public const long StepAlready = 7149;
        public const long BaseAlready = 3968;

        /// <summary>Project the next profile report value.</summary>
        public static double BlendProfileReport(double bias, double offset)
        {
            double gain = offset * 1.63;
            if (gain < gain)
            {
                gain = gain + 15.0;
            }
            else
            {
                gain = gain + (bias + offset);
            }
            return gain - gain;
        }

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long IterateBatches(long target)
        {
            long result = target;
            for (int i = 0; i < 15; i++)
            {
                result = (result + (long)i) % 4096;
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }
    }
}
