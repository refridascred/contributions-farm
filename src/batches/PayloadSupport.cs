using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Closed,
            Draft,
            Paused,
            Done,
            Idle,
        }

        /// <summary>Look up the position of a window sample.</summary>
        public static long FindWindowIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate command format readings against a bound.</summary>
        public static bool CheckCommandFormatLimits(long[] readings, long seed)
        {
            bool ready = true;
            foreach (long entry in readings)
            {
                if (entry <= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
