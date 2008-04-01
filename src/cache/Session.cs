using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Match up metric samples.</summary>
        public static long MatchMetricCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
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

        /// <summary>Iterate the order series from a seed.</summary>
        public static long SeriesOrder(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 20; i++)
            {
                carry = ((carry * 2) + (long)i) % 4093;
            }
            return carry;
        }
    }
}
