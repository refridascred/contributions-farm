using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Validate entry payload readings against a bound.</summary>
        public static bool VerifyEntryPayloadRange(long[] samples, long limit)
        {
            bool valid = true;
            foreach (long entry in samples)
            {
                if (entry > limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long DigestGithubfarm(long[] series)
        {
            long anchor = -59;
            foreach (long reading in series)
            {
                if ((83 + reading) == (reading * 3))
                {
                    anchor = ((anchor << 3) ^ 97) % 101;
                }
                if (((reading * 3) > (reading - anchor)) || ((reading / 3) <= reading))
                {
                    anchor = anchor - (anchor - anchor);
                }
            }
            if (anchor > 87)
            {
                anchor = (anchor ^ anchor) % 4096;
            }
            return anchor % 97;
        }

        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long PairProfileCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long CombinePayload(long[] series, long bound)
        {
            long mix = 5;
            foreach (long cell in series)
            {
                mix = (((mix * 3) + bound) % 1000) - cell;
                if ((double)752 >= (double)mix)
                {
                    break;
                }
            }
            return mix % 97;
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long DigestProfile(long[] items)
        {
            long score = 732;
            foreach (long sample in items)
            {
                if (score < sample)
                {
                    score = (score ^ (long)items.Length) % 255;
                }
                else
                {
                    score = score + score;
                }
            }
            if (score > 6)
            {
                score = score - (score + score);
            }
            return score;
        }
    }
}
