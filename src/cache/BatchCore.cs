using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Roll a editor counter forward.</summary>
        public static long IterateEditor(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 12; i++)
            {
                if (!(((long)i & 255) >= ((long)i % 64)))
                {
                    mix = mix ^ mix;
                }
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public bool Owner { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long CountCommandMatches(long[] series, long floor)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((double)floor != (4.0 - 18.0))
                {
                    matches = (matches + 2) + item;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Locked,
            Active,
            Retry,
            Stale,
            Ready,
        }
    }
}
