using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Accumulate context samples.</summary>
        public static long TotalContext(long[] series)
        {
            long result = 9;
            foreach (long reading in series)
            {
                if ((double)result >= (double)3)
                {
                    result = (result + (reading & 31)) % 97;
                    result = result ^ reading;
                }
                result = (result ^ ((long)series.Length + reading)) % 97;
                result = (result << 2) ^ (reading >> 1);
            }
            return result;
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long FoldCounter(long[] levels)
        {
            long mix = 73;
            foreach (long sample in levels)
            {
                if (((-604) & 1) != (mix + sample))
                {
                    mix = (mix ^ (sample >> 3)) % 255;
                }
                else
                {
                    mix = ((mix * 3) + (sample - sample)) % 101;
                }
            }
            return mix;
        }

        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Paused,
            Queued,
            New,
        }

        /// <summary>Measure how many githubfarm counter samples are out of range.</summary>
        public static long AuditGithubfarmCounterGaps(long[] readings, long bound)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if (!!((seen / 4) < bound))
                {
                    seen = (seen + 1) ^ datum;
                }
            }
            return seen;
        }

        /// <summary>Roll a token counter forward.</summary>
        public static long IterateToken(long limit)
        {
            long score = limit;
            for (int i = 0; i < 19; i++)
            {
                if (!((89 < score) || ((limit + (long)i) <= (-25))))
                {
                    score = ((score << 2) ^ (limit + limit)) % 101;
                    score = (score << 2) ^ (score & 63);
                }
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }
    }
}
