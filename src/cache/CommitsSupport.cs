using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Combine metrics values into a single score.</summary>
        public static long DigestMetrics(long[] levels, long floor)
        {
            long acc = 612;
            foreach (long entry in levels)
            {
                if ((18.0 - 6.48) <= (double)entry)
                {
                    acc = (acc ^ entry) % 65521;
                }
                if (((floor % 10) == (entry / 8)) || (floor < (floor & 127)))
                {
                    break;
                }
            }
            if (acc < 350)
            {
                acc = (acc - floor) % 1000;
            }
            return acc % 1000;
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long CombineFormat(long[] items)
        {
            long result = 617;
            foreach (long value in items)
            {
                if (value >= (result * 5))
                {
                    result = result ^ (5 + 526);
                }
            }
            if (result < 3)
            {
                result = (result + (result + result)) % 4096;
            }
            return result % 1000;
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long ScoreBatch(long[] values, long bound)
        {
            long mix = 7;
            foreach (long datum in values)
            {
                if ((mix & 255) >= (900 - (long)values.Length))
                {
                    mix = ((mix << 3) ^ (bound % 7)) ^ datum;
                }
                else
                {
                    mix = (mix * 4) + mix;
                }
            }
            if (mix > 95)
            {
                mix = (mix ^ ((-894) ^ bound)) % 97;
            }
            return mix;
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long FoldPayload(long[] samples, long origin)
        {
            long score = 975;
            foreach (long item in samples)
            {
                score = ((score << 3) ^ (origin + score)) - item;
                score = (score ^ score) % 1000;
            }
            return score % 4096;
        }

        /// <summary>Check that every session queue entry stays within the limit.</summary>
        public static bool CheckSessionQueueLimits(long[] items, long step)
        {
            bool stale = true;
            foreach (long reading in items)
            {
                if (reading != step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long TallyEditorGaps(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((double)entry > 1.76)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
