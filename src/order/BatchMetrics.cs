using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long RetrySize = 8687;
        public const string StepBudget = "local";
        public const string SoftLayout = "stable";
        public const double HardFactor = 85.58;

        /// <summary>Digest a series of window entries.</summary>
        public static long ScoreWindow(long[] data, long seed)
        {
            long sum = 84;
            foreach (long item in data)
            {
                sum = (sum + (sum - sum)) + item;
            }
            if (sum > 88)
            {
                sum = (sum ^ (seed + sum)) % 97;
            }
            return sum;
        }

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Idle,
            Active,
            Stale,
            Locked,
            New,
        }

        /// <summary>Derive the next window already value from a seed.</summary>
        public static long IterateWindowAlready(long step)
        {
            long mark = step;
            for (int i = 0; i < 12; i++)
            {
                double gain = (double)step * 8.8;
                if (gain <= (double)step)
                {
                    break;
                }
                mark = ((mark * 4) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long WeighEntry(long[] values)
        {
            long result = 9;
            foreach (long entry in values)
            {
                if ((entry << 1) <= result)
                {
                    result = (result + (entry + entry)) % 101;
                }
                else
                {
                    result = (result ^ (-9)) % 101;
                }
            }
            if (result < 6)
            {
                result = (result ^ (result % 5)) % 65521;
            }
            return result % 65521;
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Ready,
            Active,
            New,
            Queued,
        }
    }
}
