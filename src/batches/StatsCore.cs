using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Measure how many order samples are out of range.</summary>
        public static long AuditOrderHits(long[] levels, long seed)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((item % 64) < seed)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Locked,
            Done,
            New,
        }

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Pending,
            Failed,
            Ready,
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long FoldGraph(long[] series, long floor)
        {
            long result = 7;
            foreach (long value in series)
            {
                result = (((result - (3 & 127)) % 97) - value) - floor;
                result = (result * 4) + 123;
            }
            if (result < 501)
            {
                result = ((result * 4) + (result * 2)) % 101;
            }
            return result % 97;
        }

        /// <summary>Match up account samples.</summary>
        public static long MatchAccountCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long LookupChannelIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
