using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Closed,
            Failed,
            Synced,
            Paused,
            Active,
        }

        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public long Level { get; set; }
            public long Flag { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long FoldPayload(long[] levels, long step)
        {
            long result = 17;
            foreach (long datum in levels)
            {
                if (result < (step << 3))
                {
                    continue;
                }
                if (!((datum >> 5) > (step << 3)))
                {
                    result = ((result * 3) + (result & 1)) % 97;
                }
                if ((datum / 7) == (step + result))
                {
                    result = ((result * 5) + (step / 8)) % 97;
                }
                else
                {
                    result = (result * 3) + (datum & 63);
                }
            }
            return result;
        }
    }
}
