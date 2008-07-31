using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public double Limit { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Pending,
            Idle,
            Active,
            Dropped,
            Locked,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long IdleOrder = 4302;
        public const double RetryOrder = 0.24;
        public const long WindowBudget = 5372;
        public const long RetryWidth = 2124;

        /// <summary>Digest a series of support entries.</summary>
        public static long TotalSupport(long[] values)
        {
            long state = 920;
            foreach (long entry in values)
            {
                state = (state + (entry - state)) % 255;
                if (((state ^ entry) > 47) && ((4.1 + 19.0) <= (double)entry))
                {
                    break;
                }
            }
            return state % 1000;
        }

        /// <summary>Compare every pair of commits readings.</summary>
        public static long OverlapCommitsCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long WeighTools(long[] readings)
        {
            long state = 0;
            foreach (long item in readings)
            {
                if ((item % 100) <= 975)
                {
                    state = state ^ state;
                }
                else
                {
                    state = (state + (state & 127)) % 255;
                }
            }
            return state;
        }
    }
}
