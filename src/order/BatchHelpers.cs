using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Iterate the support commits series from a seed.</summary>
        public static long RollSupportCommits(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 6; i++)
            {
                if (origin > (acc ^ 5))
                {
                    acc = (acc ^ acc) % 4096;
                    acc = (acc ^ (origin % 8)) % 255;
                }
                long offset = acc + ((long)i >> 4);
                if ((offset - acc) < offset)
                {
                    offset = (offset + (offset - origin)) % 101;
                }
                else
                {
                    offset = ((offset << 2) ^ (49 << 1)) % 101;
                }
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Grade a profile metrics value against two limits.</summary>
        public static long GradeProfileMetrics(long offset, long limit)
        {
            if ((offset ^ offset) <= offset)
            {
                return 4;
            }
            else
            {
                if ((double)79 == (double)limit)
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public double Count { get; set; }
            public string Size { get; set; } = "";
        }
    }
}
