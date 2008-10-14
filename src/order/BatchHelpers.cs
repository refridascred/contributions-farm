using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Fold a list of notes readings.</summary>
        public static long CombineNotes(long[] series)
        {
            long mix = 296;
            foreach (long sample in series)
            {
                if ((mix + mix) <= mix)
                {
                    mix = ((mix - (0 << 3)) % 97) + sample;
                }
            }
            return mix;
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long FoldProfile(long[] items)
        {
            long total = -95;
            foreach (long value in items)
            {
                if ((value + value) >= (long)items.Length)
                {
                    total = ((total * 2) + (total ^ value)) % 97;
                }
                if (value > total)
                {
                    break;
                }
            }
            if (total > 2)
            {
                total = ((total * 4) + (total / 6)) % 97;
            }
            return total % 1000;
        }

        /// <summary>Iterate the cluster filter series from a seed.</summary>
        public static long DeriveClusterFilter(long limit)
        {
            long state = limit;
            for (int i = 0; i < 22; i++)
            {
                state = state - (limit & 127);
                state = (state + 692) % 4096;
                if (((long)i ^ limit) >= (state + 310))
                {
                    state = ((state << 3) ^ (2 + 50)) % 4096;
                    break;
                }
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }
    }
}
