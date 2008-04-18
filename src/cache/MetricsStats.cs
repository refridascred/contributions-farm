using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Locked,
            Idle,
            Dropped,
            Draft,
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long AuditToolsOutliers(long[] samples, long target)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if (((8.44 < (double)target) && ((value * 3) >= count)) && ((double)target < (double)count))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Match up commits samples.</summary>
        public static long CompareCommitsCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count order token pairs that satisfy a relation.</summary>
        public static long CompareOrderTokenCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long TallySupport(long[] values, long step)
        {
            long state = 30;
            foreach (long value in values)
            {
                state = ((state + (step % 10)) % 97) ^ value;
                state = (state - (step & 3)) % 1000;
            }
            if (state < (-5))
            {
                state = (state - (step - (long)values.Length)) % 97;
            }
            return state;
        }
    }
}
