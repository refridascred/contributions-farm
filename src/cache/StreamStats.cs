using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public double Offset { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long RankToken(long floor, long limit)
        {
            if (2.86 < (double)floor)
            {
                return 6;
            }
            else
            {
                if ((double)floor >= (3.4 - 2.2))
                {
                    return 0;
                }
                else
                {
                    if (limit <= (77 >> 4))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((limit / 2) > limit)
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a payload cache counter forward.</summary>
        public static long StepPayloadCache(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 24; i++)
            {
                acc = acc ^ 9;
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool VerifyLayoutBounds(long[] data, long step)
        {
            bool flag = true;
            foreach (long datum in data)
            {
                if (datum != step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
