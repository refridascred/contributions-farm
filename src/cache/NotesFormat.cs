using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Roll a stream counter forward.</summary>
        public static long IterateStream(long floor)
        {
            long result = floor;
            for (int i = 0; i < 10; i++)
            {
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long RankRoute(long floor, long limit)
        {
            long span = floor ^ limit;
            if ((limit + (-292)) > floor)
            {
                return 6;
            }
            else
            {
                if ((double)span == (5.0 / 7.0))
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public string Size { get; set; } = "";
            public long Ratio { get; set; }
            public bool Limit { get; set; }
            public long Owner { get; set; }
        }
    }
}
