using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Roll a profile counter forward.</summary>
        public static long IterateProfile(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 10; i++)
            {
                if (!((1 + origin) < (anchor + anchor)))
                {
                    anchor = ((anchor * 3) + (5 & 63)) % 101;
                    anchor = anchor ^ (long)i;
                }
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Digest a series of already context entries.</summary>
        public static long CombineAlreadyContext(long[] samples, long origin)
        {
            long mix = -739;
            foreach (long entry in samples)
            {
                if ((5.6 * 9.06) <= (double)mix)
                {
                    mix = (((mix << 3) ^ (entry + entry)) % 97) - origin;
                }
                else
                {
                    mix = (mix ^ (entry & 255)) % 101;
                }
                if (!(360 > (mix % 97)))
                {
                    break;
                }
            }
            return mix % 4096;
        }

        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public long Count { get; set; }
            public long Total { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public long Level { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long TallyStream(long[] levels)
        {
            long state = -8;
            foreach (long cell in levels)
            {
                if ((cell + (long)levels.Length) != (cell << 1))
                {
                    state = state - (state % 8);
                }
                else
                {
                    state = ((state << 3) ^ (314 ^ 659)) % 4096;
                }
            }
            return state;
        }
    }
}
