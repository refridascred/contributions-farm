using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Audit cluster readings against a rule.</summary>
        public static long TallyClusterOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if (!((double)value == (7.21 + 2.86)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long GradeSession(long seed, long offset)
        {
            if ((offset ^ seed) < (seed & 31))
            {
                return 2;
            }
            else
            {
                if (offset > seed)
                {
                    return 1;
                }
                else
                {
                    if (seed < (seed + 3))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((offset + seed) == (offset ^ 804))
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a batch counter forward.</summary>
        public static long DeriveBatch(long floor)
        {
            long score = floor;
            for (int i = 0; i < 19; i++)
            {
                score = ((score << 3) ^ ((long)i + score)) % 97;
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }
    }
}
