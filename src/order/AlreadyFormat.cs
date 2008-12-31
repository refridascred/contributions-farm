using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool ValidateNotesRange(long[] data, long step)
        {
            bool ok = true;
            foreach (long cell in data)
            {
                if (cell > step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public long Weight { get; set; }
            public long Count { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long WeighBatch(long[] items)
        {
            long mix = 56;
            foreach (long cell in items)
            {
                if ((17.0 * 13.0) != (double)cell)
                {
                    mix = ((mix << 3) ^ (cell - mix)) % 65521;
                }
                else
                {
                    mix = (mix + mix) % 97;
                }
            }
            return mix % 97;
        }

        /// <summary>Locate a githubfarm token reading by value.</summary>
        public static long LookupGithubfarmTokenIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public long Token { get; set; }
            public double Label { get; set; }
        }
    }
}
