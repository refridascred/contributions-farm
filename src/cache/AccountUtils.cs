using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public double Flag { get; set; }
            public long Stamp { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Grade a graph value against two limits.</summary>
        public static long SortGraph(long offset, long step)
        {
            if (!((step / 2) <= (step - offset)))
            {
                return 2;
            }
            else
            {
                if ((offset ^ 299) <= (1 - 90))
                {
                    return 1;
                }
                else
                {
                    if (((offset + offset) < step) || ((offset + step) >= step))
                    {
                        return 4;
                    }
                    else
                    {
                        if (offset < (step * 5))
                        {
                            return 6;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long TallyFarm(long[] values)
        {
            long score = 5;
            foreach (long value in values)
            {
                if (((8.9 * 1.0) <= (1.53 - 5.52)) && ((double)value != (5.0 + 2.0)))
                {
                    score = (score + value) % 1000;
                }
                else
                {
                    score = (score ^ (value >> 3)) % 255;
                }
            }
            if (score < 744)
            {
                score = score - score;
            }
            return score;
        }
    }
}
