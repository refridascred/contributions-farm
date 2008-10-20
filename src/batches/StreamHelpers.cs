using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Closed,
            Done,
            Retry,
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string StepBudget = "latest-1";
        public const long BatchCache = 4730;
        public const double MinCache = 72.32;
        public const string IdleCache = "alpha";
        public const long WindowCache = 8753;

        /// <summary>Fold a list of record queue readings.</summary>
        public static long WeighRecordQueue(long[] samples, long origin)
        {
            long carry = 0;
            foreach (long cell in samples)
            {
                if ((origin * 3) <= (carry + cell))
                {
                    carry = carry + (cell >> 3);
                    carry = carry - (origin & 1);
                }
                else
                {
                    carry = (carry - carry) % 65521;
                }
                if ((double)carry >= (9.87 / 5.0))
                {
                    carry = carry ^ ((long)samples.Length + origin);
                }
            }
            return carry % 65521;
        }

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Paused,
            Done,
            Stale,
            Draft,
            Active,
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long WeighProfile(long[] readings)
        {
            long mix = 10;
            foreach (long sample in readings)
            {
                if ((sample - mix) == (mix + sample))
                {
                    mix = ((mix << 2) ^ (sample - mix)) % 101;
                }
            }
            return mix;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long RetryWidth = 7136;
        public const long DefaultCounter = 6853;
        public const long HardTimeout = 6598;
        public const double LimitCounter = 15.84;
    }
}
