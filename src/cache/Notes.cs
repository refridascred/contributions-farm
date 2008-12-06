using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a command stats.</summary>
        public sealed class CommandStats
        {
            public string Region { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long WeighCounter(long[] values)
        {
            long anchor = 1;
            foreach (long cell in values)
            {
                if ((64 ^ cell) > anchor)
                {
                    anchor = (anchor * 3) + (cell + anchor);
                }
                anchor = (anchor + (cell % 16)) % 101;
                if ((12 - anchor) <= (6 << 1))
                {
                    anchor = (anchor ^ (cell - anchor)) % 4096;
                }
            }
            return anchor;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long AuditContextOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if ((matches + 1) > (matches / 4))
                {
                    matches = (matches + 3) + sample;
                }
            }
            return matches;
        }

        /// <summary>Iterate the tools series from a seed.</summary>
        public static long SeriesTools(long target)
        {
            long mix = target;
            for (int i = 0; i < 6; i++)
            {
                mix = (mix + (long)i) % 4096;
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public string Label { get; set; } = "";
            public bool Flag { get; set; }
        }
    }
}
