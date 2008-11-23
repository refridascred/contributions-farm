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

        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Closed,
            Active,
            Pending,
            Failed,
        }

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

        /// <summary>Count channel support pairs that satisfy a relation.</summary>
        public static long MatchChannelSupportCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
