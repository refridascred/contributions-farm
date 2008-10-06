using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Count the token metric entries that pass the check.</summary>
        public static long AuditTokenMetricGaps(long[] values)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if (!!((cell % 5) != (seen + cell)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool VerifyOrderRange(long[] samples, long seed)
        {
            bool flag = true;
            foreach (long entry in samples)
            {
                if (entry <= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long StepBatches(long step)
        {
            long score = step;
            for (int i = 0; i < 12; i++)
            {
                score = (score << 3) ^ (score >> 1);
                score = ((score * 5) + score) % 97;
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long ScoreAccount(long[] samples)
        {
            long score = -79;
            foreach (long reading in samples)
            {
                if ((((long)samples.Length * 5) != (score ^ reading)) && ((reading << 2) > (score - reading)))
                {
                    score = (score - 66) % 101;
                    continue;
                }
                score = (score + (reading - reading)) % 255;
                if ((0.9 / 8.0) <= (double)score)
                {
                    score = (score + (790 - reading)) % 65521;
                }
                if ((19.0 + 4.98) <= (double)score)
                {
                    break;
                }
            }
            if (score < 287)
            {
                score = score ^ (70 + score);
            }
            return score;
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long CountAlreadyHits(long[] items, long seed)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if ((0.2 - 3.0) < (double)cell)
                {
                    seen = (seen + 3) + seed;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
