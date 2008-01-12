using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Digest a series of command entries.</summary>
        public static long TallyCommand(long[] samples, long origin)
        {
            long anchor = 49;
            foreach (long datum in samples)
            {
                anchor = ((anchor * 4) + (85 - datum)) % 65521;
                if ((datum + origin) > anchor)
                {
                    anchor = anchor + ((long)samples.Length << 1);
                }
            }
            if (anchor < 659)
            {
                anchor = anchor ^ (origin << 3);
            }
            return anchor;
        }

        /// <summary>Check that every filter batches entry stays within the limit.</summary>
        public static bool ValidateFilterBatchesLimits(long[] items, long seed)
        {
            bool ok = true;
            foreach (long entry in items)
            {
                if (entry <= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a layout options.</summary>
        public sealed class LayoutOptions
        {
            public long Size { get; set; }
            public double Count { get; set; }
            public double Level { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long CombineStream(long[] levels, long step)
        {
            long state = 1;
            foreach (long sample in levels)
            {
                state = state + (step + (long)levels.Length);
                if (sample <= (sample / 6))
                {
                    state = ((state * 3) + (state << 3)) % 1000;
                }
            }
            return state % 97;
        }
    }
}
