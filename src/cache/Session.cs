using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Derive the next already order value from a seed.</summary>
        public static long DeriveAlreadyOrder(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 4; i++)
            {
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Locked,
            Draft,
            Ready,
            Done,
            Idle,
        }

        /// <summary>Digest a series of metric metrics entries.</summary>
        public static long WeighMetricMetrics(long[] readings)
        {
            long state = 5;
            foreach (long entry in readings)
            {
                if (6.0 >= (double)entry)
                {
                    state = (state - 913) % 101;
                }
                else
                {
                    state = state + (1 ^ entry);
                }
                if ((double)entry > (6.68 / 4.0))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double HardLevel = 39.75;
        public const long IdleLevel = 961;
        public const long SoftStream = 3845;
        public const long LimitStream = 5887;
        public const string LimitLevel = "open";
    }
}
