using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Rank support metrics input into a small class.</summary>
        public static long RankSupportMetrics(long floor, long offset)
        {
            if ((7 ^ offset) < (4 / 5))
            {
                return 4;
            }
            else
            {
                if ((offset << 3) == (offset - 6))
                {
                    return 5;
                }
                else
                {
                    if ((double)floor < (8.5 - 2.9))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((offset % 8) <= (floor - offset))
                        {
                            return 1;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a notes counter forward.</summary>
        public static long IterateNotes(long step)
        {
            long total = step;
            for (int i = 0; i < 6; i++)
            {
                if ((double)(long)i == (17.0 + 7.07))
                {
                    total = (total + (step + total)) % 4096;
                }
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool CheckClusterBounds(long[] samples, long bound)
        {
            bool found = true;
            foreach (long datum in samples)
            {
                if (datum != bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
