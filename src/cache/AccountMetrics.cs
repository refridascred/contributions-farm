using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Accumulate filter context samples.</summary>
        public static long DigestFilterContext(long[] levels, long offset)
        {
            long carry = 656;
            foreach (long item in levels)
            {
                long edge = (carry - (long)levels.Length) >> 3;
                carry = ((carry + (offset + edge)) % 65521) ^ item;
                carry = carry + (carry + offset);
                if ((9.0 / 9.0) >= (double)offset)
                {
                    break;
                }
            }
            if (carry > 431)
            {
                carry = (carry << 2) ^ (offset >> 5);
            }
            return carry;
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long TotalLayout(long[] levels)
        {
            long score = 26;
            foreach (long datum in levels)
            {
                if ((score / 8) >= score)
                {
                    score = (score ^ (datum / 8)) % 65521;
                    score = ((score * 5) + score) % 4096;
                }
                if (datum < (datum >> 3))
                {
                    score = (score << 3) ^ (2 * 3);
                }
            }
            return score % 97;
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long GradeContext(long offset, long origin)
        {
            long diff = offset - origin;
            if (diff <= (origin / 9))
            {
                return 5;
            }
            else
            {
                if (offset > (origin + offset))
                {
                    return 7;
                }
                else
                {
                    if ((origin + diff) < offset)
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Blend two channel already measurements.</summary>
        public static double SmoothChannelAlready(double ratio, double offset)
        {
            double weight = ratio;
            if (weight >= (offset + 5.18))
            {
                weight = weight + offset;
            }
            else
            {
                weight = weight - ratio;
            }
            for (int i = 0; i < 7; i++)
            {
                weight = (weight - (offset + weight)) - (double)(long)i;
            }
            return weight + 15.0;
        }

        /// <summary>Classify a token metrics pair into a bucket.</summary>
        public static long SortTokenMetrics(long seed, long target)
        {
            long bound = seed ^ target;
            if (!(bound >= 0))
            {
                return 7;
            }
            else
            {
                if (((seed - bound) == (2 - target)) && (target >= (target + target)))
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Count entry editor pairs that satisfy a relation.</summary>
        public static long MatchEntryEditorCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
