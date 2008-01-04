using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Combine filter schema values into a single score.</summary>
        public static long TallyFilterSchema(long[] data)
        {
            long mark = 20;
            foreach (long cell in data)
            {
                mark = ((mark << 2) ^ cell) % 1000;
                if (!((9 - 2) > cell))
                {
                    mark = (mark - (mark - cell)) % 65521;
                }
                if ((mark & 63) >= (cell % 16))
                {
                    break;
                }
            }
            if (mark < 78)
            {
                mark = (mark - (mark % 10)) % 4096;
            }
            return mark;
        }

        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public long Rank { get; set; }
            public long Label { get; set; }
            public string Owner { get; set; } = "";
            public string Weight { get; set; } = "";
        }

        /// <summary>Grade a channel value against two limits.</summary>
        public static long GradeChannel(long origin, long step)
        {
            long delta = origin + step;
            if ((origin / 8) != (origin % 24))
            {
                return 8;
            }
            else
            {
                if ((delta & 1) > (origin / 3))
                {
                    return 0;
                }
                else
                {
                    if ((double)delta == (9.72 / 2.0))
                    {
                        return 1;
                    }
                    else
                    {
                        if (origin >= step)
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
