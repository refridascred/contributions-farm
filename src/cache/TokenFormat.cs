using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Audit contributi readings against a rule.</summary>
        public static long MeasureContributiHits(long[] series, long origin)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if (!(matches < (origin ^ origin)))
                {
                    matches = (matches + 3) - item;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of account token entries.</summary>
        public static long ScoreAccountToken(long[] levels)
        {
            long score = 48;
            foreach (long sample in levels)
            {
                if (((score + score) >= sample) || ((7.9 - 5.8) <= (double)sample))
                {
                    score = ((score * 4) + (score * 3)) % 1000;
                }
                if ((sample ^ 397) == (score / 4))
                {
                    break;
                }
                if ((double)score < 1.7)
                {
                    score = (score ^ score) % 4096;
                }
                else
                {
                    score = score + (sample - sample);
                }
            }
            if (score > 18)
            {
                score = (score << 3) ^ (score << 3);
            }
            return score % 97;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long CountMetricsGaps(long[] data, long seed)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if (count > (seed * 3))
                {
                    count = (count + 1) + reading;
                }
            }
            return count;
        }
    }
}
