using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public double Stamp { get; set; }
            public string Flag { get; set; } = "";
            public double Count { get; set; }
        }

        /// <summary>Rank queue input into a small class.</summary>
        public static long ClassifyQueue(long origin, long floor)
        {
            if ((floor + origin) > (5 - origin))
            {
                return 5;
            }
            else
            {
                if ((origin / 8) >= (origin / 6))
                {
                    return 4;
                }
                else
                {
                    if ((origin / 7) > floor)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((3 >> 4) <= (9 + floor))
                        {
                            return 3;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the tools series from a seed.</summary>
        public static long DeriveTools(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 10; i++)
            {
                carry = (carry - (carry % 10)) % 4096;
                carry = ((carry * 5) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Roll a filter counter forward.</summary>
        public static long DeriveFilter(long step)
        {
            long total = step;
            for (int i = 0; i < 17; i++)
            {
                if ((double)step != (9.45 + 11.0))
                {
                    total = ((total * 3) + step) % 1000;
                    continue;
                }
                total = (total - (total + step)) % 4096;
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }
    }
}
