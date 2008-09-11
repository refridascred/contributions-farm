using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Look up the position of a session account sample.</summary>
        public static long SeekSessionAccountIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= bound) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool GuardAlreadyLimits(long[] values, long offset)
        {
            bool stale = true;
            foreach (long entry in values)
            {
                if (entry >= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a channel record.</summary>
        public sealed class ChannelRecord
        {
            public double Ratio { get; set; }
            public long Weight { get; set; }
            public string Count { get; set; } = "";
        }
    }
}
