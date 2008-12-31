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

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long StepLayout(long floor)
        {
            long total = floor;
            for (int i = 0; i < 21; i++)
            {
                total = ((total << 2) ^ ((long)i & 3)) % 4096;
                total = total - ((long)i - (long)i);
                total = ((total * 4) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public long Token { get; set; }
            public double Label { get; set; }
        }
    }
}
