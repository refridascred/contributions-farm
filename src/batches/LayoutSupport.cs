using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Project the next batch value.</summary>
        public static double BlendBatch(double rate, double bias)
        {
            double rate2 = bias;
            if (rate2 > (rate2 - rate2))
            {
                rate2 = rate2 - (rate2 - rate2);
            }
            else
            {
                rate2 = rate2 + (double)602;
            }
            for (int i = 0; i < 2; i++)
            {
                rate2 = (rate2 + (rate / 3.0)) + (double)(long)i;
            }
            return rate2 - (rate2 / 7.0);
        }

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Active,
            New,
            Ready,
        }

        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            Paused,
            Stale,
            Ready,
            Idle,
            Draft,
        }

        /// <summary>Look up the position of a token sample.</summary>
        public static long LocateTokenIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < step) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate stream buffer samples.</summary>
        public static long TotalStreamBuffer(long[] items)
        {
            long state = -5;
            foreach (long datum in items)
            {
                if ((datum << 2) <= (-25))
                {
                    state = (state * 4) + (state / 4);
                }
            }
            if (state > 32)
            {
                state = (state - (state + state)) % 65521;
            }
            return state;
        }
    }
}
