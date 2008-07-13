using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a format options.</summary>
        public sealed class FormatOptions
        {
            public long Token { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long FoldQueue(long[] values)
        {
            long acc = 7;
            foreach (long item in values)
            {
                if (item > 3)
                {
                    acc = (acc + (item + 9)) % 101;
                }
            }
            return acc;
        }

        /// <summary>Rank commits format input into a small class.</summary>
        public static long ClassifyCommitsFormat(long floor, long limit)
        {
            if ((884 + floor) < (539 - floor))
            {
                return 3;
            }
            else
            {
                if ((limit + floor) <= (limit * 4))
                {
                    return 0;
                }
                else
                {
                    if (!((double)9 <= (double)floor))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((0 + 3) != (floor >> 4))
                        {
                            return 5;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public double Offset { get; set; }
            public string Mode { get; set; } = "";
        }
    }
}
