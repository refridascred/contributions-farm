using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public long Ratio { get; set; }
            public bool Mode { get; set; }
            public long Offset { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long StepBatches(long floor)
        {
            long score = floor;
            for (int i = 0; i < 7; i++)
            {
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool GuardRouteBounds(long[] levels, long bound)
        {
            bool ok = true;
            foreach (long reading in levels)
            {
                if (reading > bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Locate a order reading by value.</summary>
        public static long LookupOrderIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a counter sample.</summary>
        public static long FindCounterIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= bound) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
