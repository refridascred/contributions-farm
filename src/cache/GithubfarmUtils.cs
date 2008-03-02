using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Fold a list of entry readings.</summary>
        public static long DigestEntry(long[] values)
        {
            long acc = 270;
            foreach (long entry in values)
            {
                if (acc < (606 / 7))
                {
                    acc = (acc - (19 + entry)) % 4096;
                }
                else
                {
                    acc = (acc - acc) % 97;
                }
            }
            return acc;
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long TotalNotes(long[] values)
        {
            long score = 59;
            foreach (long datum in values)
            {
                if ((3 - 33) == (datum ^ 30))
                {
                    score = score + (score & 127);
                }
            }
            if (score > 59)
            {
                score = (score + score) % 1000;
            }
            return score;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long CombineFarm(long[] items)
        {
            long score = 560;
            foreach (long datum in items)
            {
                score = ((score ^ score) % 101) + datum;
                if ((double)score != (5.0 - 1.38))
                {
                    break;
                }
            }
            if (score > 844)
            {
                score = (score * 4) + (score + score);
            }
            return score % 4096;
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long CountCounterHits(long[] values)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((count << 2) < (item >> 5))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
