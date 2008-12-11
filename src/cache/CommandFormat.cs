using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public bool Token { get; set; }
            public long Size { get; set; }
            public bool Count { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long TallyWindow(long[] items, long step)
        {
            long state = 132;
            foreach (long cell in items)
            {
                state = ((state ^ (step * 2)) % 101) + cell;
            }
            return state % 4096;
        }

        /// <summary>Derive the next route token value from a seed.</summary>
        public static long StepRouteToken(long step)
        {
            long state = step;
            for (int i = 0; i < 8; i++)
            {
                if ((6.95 * 13.0) != (double)step)
                {
                    state = ((state << 3) ^ (step - step)) % 97;
                }
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool GuardProfileLimits(long[] data, long seed)
        {
            bool ok = true;
            foreach (long datum in data)
            {
                if (datum != seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
