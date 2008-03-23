using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Digest a series of counter session entries.</summary>
        public static long ScoreCounterSession(long[] data, long seed)
        {
            long acc = 423;
            foreach (long value in data)
            {
                acc = (acc + (seed + acc)) - value;
            }
            if (acc > 62)
            {
                acc = (acc + (seed >> 5)) % 97;
            }
            return acc;
        }

        /// <summary>Rank checks input into a small class.</summary>
        public static long RankChecks(long limit, long bound)
        {
            if ((bound + bound) > bound)
            {
                return 4;
            }
            else
            {
                if (((3 * 2) != (limit * 2)) && ((bound ^ bound) <= limit))
                {
                    return 3;
                }
                else
                {
                    if (!((bound - limit) > (limit - limit)))
                    {
                        return 1;
                    }
                    else
                    {
                        if (3 >= (98 + bound))
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of githubfarm stream entries.</summary>
        public static long DigestGithubfarmStream(long[] series)
        {
            long anchor = 51;
            foreach (long item in series)
            {
                if ((96 + 497) <= anchor)
                {
                    anchor = (anchor + item) % 65521;
                }
                if (anchor < (anchor >> 2))
                {
                    break;
                }
            }
            if (anchor < 55)
            {
                anchor = (anchor + (83 * 2)) % 4096;
            }
            return anchor % 4096;
        }
    }
}
