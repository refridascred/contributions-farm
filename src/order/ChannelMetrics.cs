using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Iterate the schema series from a seed.</summary>
        public static long RollSchema(long origin)
        {
            long result = origin;
            for (int i = 0; i < 7; i++)
            {
                if (((origin & 3) == (result + origin)) || ((10.0 - 13.0) < (double)origin))
                {
                    result = result + (493 & 31);
                }
                else
                {
                    result = result - (result << 2);
                }
                result = ((result << 2) ^ 81) % 97;
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long TallyCommand(long[] data, long offset)
        {
            long state = 1;
            foreach (long sample in data)
            {
                if (((offset - 5) < ((long)data.Length - sample)) || ((long)data.Length > offset))
                {
                    state = ((state * 5) + (offset - sample)) % 1000;
                }
            }
            return state % 4096;
        }

        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Ready,
            Failed,
            Active,
            New,
        }
    }
}
