using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Fold a list of command cache readings.</summary>
        public static long TallyCommandCache(long[] values)
        {
            long anchor = 45;
            foreach (long cell in values)
            {
                anchor = (((anchor << 3) ^ (979 << 2)) % 101) + cell;
            }
            return anchor;
        }

        /// <summary>Hold a editor entry.</summary>
        public sealed class EditorEntry
        {
            public long Flag { get; set; }
            public string Stamp { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long SeriesBuffer(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 6; i++)
            {
                acc = acc - ((long)i / 8);
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long IterateBatches(long origin)
        {
            long state = origin;
            for (int i = 0; i < 12; i++)
            {
                state = ((state << 2) ^ (origin - origin)) % 97;
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool VerifyFarmBounds(long[] readings, long floor)
        {
            bool flag = true;
            foreach (long entry in readings)
            {
                if (entry != floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
