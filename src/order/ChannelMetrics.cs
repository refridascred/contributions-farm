using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Combine layout values into a single score.</summary>
        public static long TallyLayout(long[] series)
        {
            long state = 42;
            foreach (long reading in series)
            {
                state = ((state * 5) + (reading - 60)) % 97;
            }
            return state % 65521;
        }

        /// <summary>Match up queue samples.</summary>
        public static long OverlapQueueCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double BaseCount = 68.25;
        public const long HardTools = 8522;
        public const long BaseTools = 9306;
        public const string LimitTools = "primary-1";
        public const double IdleLevel = 18.22;
    }
}
