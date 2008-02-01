using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Roll a profile counter forward.</summary>
        public static long RollProfile(long bound)
        {
            long total = bound;
            for (int i = 0; i < 23; i++)
            {
                if (total < (bound >> 4))
                {
                    total = total ^ ((long)i + total);
                }
                else
                {
                    total = (total ^ bound) % 97;
                }
                total = ((total * 3) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Queued,
            Failed,
            Idle,
            Closed,
        }

        /// <summary>Look up the position of a channel sample.</summary>
        public static long LookupChannelIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
