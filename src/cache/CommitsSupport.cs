using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public string Score { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long PairWindowCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long DeriveLayout(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 19; i++)
            {
                if ((8.0 + 8.23) < (double)anchor)
                {
                    continue;
                }
                else
                {
                    anchor = (anchor - (floor % 7)) % 97;
                }
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Match up commits samples.</summary>
        public static long OverlapCommitsCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long RetryDepth = 5277;
        public const double IdleTimeout = 70.25;
        public const string CacheBudget = "alpha";

        /// <summary>Grade a editor value against two limits.</summary>
        public static long BucketEditor(long origin, long offset)
        {
            long offset2 = origin ^ offset;
            if ((double)offset <= 2.0)
            {
                return 3;
            }
            else
            {
                if ((offset2 >> 3) <= (origin << 3))
                {
                    return 0;
                }
                else
                {
                    if ((origin - offset2) == (origin ^ 9))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((9.05 / 4.0) < (double)offset2)
                        {
                            return 8;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
