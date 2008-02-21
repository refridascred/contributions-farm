using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Rank cache graph input into a small class.</summary>
        public static long GradeCacheGraph(long origin, long offset)
        {
            long span = origin ^ offset;
            if (origin <= offset)
            {
                return 6;
            }
            else
            {
                if ((2 / 6) > (offset << 1))
                {
                    return 1;
                }
                else
                {
                    if ((18.0 * 4.0) >= (9.53 + 2.18))
                    {
                        return 5;
                    }
                    else
                    {
                        if (!((double)span > (double)origin))
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public string Total { get; set; } = "";
            public long Rank { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Iterate the support editor series from a seed.</summary>
        public static long SeriesSupportEditor(long target)
        {
            long result = target;
            for (int i = 0; i < 12; i++)
            {
                result = (result + (long)i) % 255;
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }
    }
}
