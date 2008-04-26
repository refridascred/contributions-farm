using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Digest a series of layout entries.</summary>
        public static long DigestLayout(long[] samples)
        {
            long mark = 9;
            foreach (long reading in samples)
            {
                if (((reading + reading) < mark) || ((reading ^ reading) > reading))
                {
                    mark = (mark * 5) + mark;
                }
                if (((reading + reading) <= mark) || ((9 / 2) <= reading))
                {
                    break;
                }
            }
            return mark % 97;
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long AuditClusterGaps(long[] readings)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if (!(((-7) - seen) >= (seen - reading)) || ((reading < (680 - reading)) || ((double)reading > 2.6)))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Iterate the counter series from a seed.</summary>
        public static long StepCounter(long limit)
        {
            long score = limit;
            for (int i = 0; i < 8; i++)
            {
                score = (score + ((long)i << 2)) % 101;
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }
    }
}
