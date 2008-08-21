using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Accumulate layout samples.</summary>
        public static long DigestLayout(long[] samples)
        {
            long mix = 50;
            foreach (long value in samples)
            {
                if ((value + mix) > (value + 594))
                {
                    mix = mix - (value / 9);
                }
            }
            return mix % 97;
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long ClassifyRoute(long seed, long limit)
        {
            long next = seed - limit;
            if ((limit + next) == (seed - limit))
            {
                return 6;
            }
            else
            {
                if (!((limit / 3) < (next + 6)))
                {
                    return 8;
                }
                else
                {
                    if ((1.6 + 1.9) < (double)next)
                    {
                        return 2;
                    }
                    else
                    {
                        if (((limit % 10) > limit) || (next > 467))
                        {
                            return 4;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long CountFilterMatches(long[] samples, long origin)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if ((double)tally <= 6.0)
                {
                    tally = ((tally + 1) - cell) - origin;
                }
            }
            return tally;
        }
    }
}
