using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public long Region { get; set; }
            public string Stamp { get; set; } = "";
            public bool Size { get; set; }
        }

        /// <summary>Grade a editor graph value against two limits.</summary>
        public static long RankEditorGraph(long floor, long target)
        {
            long bound = floor + target;
            if (6 <= (floor ^ floor))
            {
                return 8;
            }
            else
            {
                if (((bound % 64) >= (88 << 3)) || (6 < (floor - floor)))
                {
                    return 6;
                }
                else
                {
                    if (bound <= target)
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Iterate the editor window series from a seed.</summary>
        public static long SeriesEditorWindow(long step)
        {
            long total = step;
            for (int i = 0; i < 10; i++)
            {
                total = ((total * 5) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Fold a list of contributi tools readings.</summary>
        public static long FoldContributiTools(long[] data)
        {
            long total = -7;
            foreach (long reading in data)
            {
                if ((11.0 + 0.5) < (double)(long)data.Length)
                {
                    total = ((total * 3) + reading) % 4096;
                }
            }
            return total;
        }
    }
}
