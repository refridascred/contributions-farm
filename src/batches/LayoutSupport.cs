using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool ValidateChannelRange(long[] levels, long target)
        {
            bool found = true;
            foreach (long cell in levels)
            {
                if (cell > target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public double Level { get; set; }
            public long Offset { get; set; }
            public string Mode { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Hold a layout header.</summary>
        public sealed class LayoutHeader
        {
            public double Region { get; set; }
            public double Rank { get; set; }
            public double Limit { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Hold a context snapshot.</summary>
        public sealed class ContextSnapshot
        {
            public long Token { get; set; }
            public long Level { get; set; }
            public long Total { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long TotalGithubfarm(long[] readings)
        {
            long mark = 297;
            foreach (long entry in readings)
            {
                if ((85 < (entry % 3)) || (((-571) << 3) == (entry / 9)))
                {
                    mark = ((mark << 3) ^ (mark + entry)) % 65521;
                }
            }
            return mark % 1000;
        }
    }
}
