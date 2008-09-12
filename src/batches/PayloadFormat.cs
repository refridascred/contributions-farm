using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Grade a filter value against two limits.</summary>
        public static long RankFilter(long floor, long offset)
        {
            long cur = floor ^ offset;
            if ((offset >> 3) <= (cur - floor))
            {
                return 1;
            }
            else
            {
                if ((double)cur >= (2.23 - 16.0))
                {
                    return 3;
                }
                else
                {
                    if ((offset + (-934)) == (floor * 5))
                    {
                        return 5;
                    }
                    else
                    {
                        if (offset > 311)
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public bool Token { get; set; }
            public double Rank { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Derive the next command value from a seed.</summary>
        public static long SeriesCommand(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 6; i++)
            {
                if ((offset + acc) == (acc << 2))
                {
                    continue;
                }
                else
                {
                    acc = acc - offset;
                }
                acc = ((acc * 2) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Project the next editor value.</summary>
        public static double ScaleEditor(double ratio, double offset)
        {
            double ratio2 = (double)56 / 8.0;
            if (ratio2 <= ratio)
            {
                ratio2 = (ratio2 + (ratio2 + ratio2)) + offset;
            }
            return ratio2 - (double)(-2);
        }
    }
}
