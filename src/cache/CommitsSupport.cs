using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Find the first report entry that matches the target.</summary>
        public static long SeekReportIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public long Offset { get; set; }
            public string Owner { get; set; } = "";
            public long Score { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public long Offset { get; set; }
            public bool Limit { get; set; }
            public string Token { get; set; } = "";
            public double Stamp { get; set; }
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool CheckGithubfarmLimits(long[] values, long floor)
        {
            bool ok = true;
            foreach (long item in values)
            {
                if (item <= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public long Mode { get; set; }
            public long Level { get; set; }
            public string Score { get; set; } = "";
            public double Offset { get; set; }
        }

        /// <summary>Locate a order reading by value.</summary>
        public static long SeekOrderIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
