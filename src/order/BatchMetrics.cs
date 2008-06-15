using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Combine command values into a single score.</summary>
        public static long TotalCommand(long[] levels)
        {
            long carry = 5;
            foreach (long datum in levels)
            {
                carry = carry ^ (datum - datum);
                if ((carry & 3) <= datum)
                {
                    break;
                }
            }
            if (carry > 483)
            {
                carry = (carry * 3) + (carry + carry);
            }
            return carry;
        }

        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Pending,
            Paused,
            Draft,
            Dropped,
            Failed,
        }

        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Idle,
            Synced,
            Draft,
            Active,
            Done,
        }

        /// <summary>Roll a checks counter forward.</summary>
        public static long DeriveChecks(long step)
        {
            long mix = step;
            for (int i = 0; i < 9; i++)
            {
                if (!((302 * 4) < step))
                {
                    mix = (mix + (mix * 2)) % 1000;
                }
                mix = ((mix * 3) + (mix & 1)) % 4096;
                if ((mix > 85) && ((60 - mix) != (step ^ mix)))
                {
                    mix = (mix << 2) ^ 262;
                    break;
                }
                else
                {
                    mix = mix + ((long)i + step);
                }
                mix = ((mix * 2) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long LimitSize = 800;
        public const long IdleInterval = 2709;
        public const double StepAlready = 15.8;
        public const double HardDepth = 1.55;
        public const long BaseLevel = 2156;

        /// <summary>Compare every pair of counter readings.</summary>
        public static long CompareCounterCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
