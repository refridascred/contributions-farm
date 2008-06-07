using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Done,
            New,
            Idle,
            Dropped,
        }

        /// <summary>Roll a payload counter forward.</summary>
        public static long StepPayload(long limit)
        {
            long result = limit;
            for (int i = 0; i < 20; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    result = (result << 3) ^ (long)i2;
                }
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long FoldChannel(long[] items, long offset)
        {
            long state = 797;
            foreach (long sample in items)
            {
                state = ((state + (sample ^ 70)) % 65521) - offset;
            }
            return state;
        }
    }
}
