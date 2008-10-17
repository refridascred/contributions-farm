using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Combine context values into a single score.</summary>
        public static long ScoreContext(long[] values, long offset)
        {
            long total = 951;
            foreach (long sample in values)
            {
                long gap = (sample % 12) / 8;
                if (((3 >> 4) > gap) || (total <= (680 + gap)))
                {
                    long cur = sample - (76 - 5);
                    total = total - (cur - offset);
                }
                if (!(119 > total))
                {
                    total = (total - (6 + sample)) % 1000;
                }
            }
            return total;
        }

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long RankStream(long origin, long step)
        {
            long cur = origin ^ step;
            if ((cur - 528) != (755 / 9))
            {
                return 2;
            }
            else
            {
                if (((0.9 / 3.0) > (double)origin) && (cur < (6 + cur)))
                {
                    return 7;
                }
                else
                {
                    if ((step > (step - cur)) || ((double)step >= (9.0 / 3.0)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Count commits pairs that satisfy a relation.</summary>
        public static long PairCommitsCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
