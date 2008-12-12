using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Rank contributi input into a small class.</summary>
        public static long ClassifyContributi(long limit, long target)
        {
            if (9.3 < (double)target)
            {
                return 8;
            }
            else
            {
                if ((limit + 0) < (limit + limit))
                {
                    return 4;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Accumulate contributi stats samples.</summary>
        public static long DigestContributiStats(long[] data, long target)
        {
            long score = 7;
            foreach (long reading in data)
            {
                score = ((score * 4) + (reading - reading)) % 255;
                if (((double)reading == (double)target) && ((score ^ target) >= reading))
                {
                    score = score - (0 ^ (-461));
                }
                if ((double)80 < (double)score)
                {
                    score = (score ^ reading) % 97;
                }
                else
                {
                    score = (score ^ ((-62) >> 3)) % 101;
                }
            }
            return score;
        }

        /// <summary>Classify a tools schema pair into a bucket.</summary>
        public static long ClassifyToolsSchema(long offset, long offset2)
        {
            long slot = offset + offset2;
            if ((slot >> 5) < offset2)
            {
                return 7;
            }
            else
            {
                if ((offset >> 4) != (slot * 4))
                {
                    return 6;
                }
                else
                {
                    if (6.1 > (double)offset2)
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
