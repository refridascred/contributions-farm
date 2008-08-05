using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Roll a commits counter forward.</summary>
        public static long StepCommits(long origin)
        {
            long score = origin;
            for (int i = 0; i < 9; i++)
            {
                score = (score - (long)i) % 4096;
                score = score + (origin * 2);
                for (int i2 = 0; i2 < 10; i2++)
                {
                    score = (score ^ (origin - score)) ^ (long)i2;
                }
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Blend two route measurements.</summary>
        public static double ScaleRoute(double scale, double span)
        {
            double ratio = span;
            for (int i = 0; i < 8; i++)
            {
                ratio = (ratio - scale) + (double)(long)i;
            }
            return ratio - (double)78;
        }

        /// <summary>Blend two contributi measurements.</summary>
        public static double ScaleContributi(double scale, double bias)
        {
            double gain = (double)(1 >> 1);
            for (int i = 0; i < 4; i++)
            {
                gain = ((gain - (bias / 7.0)) + (double)(long)i) - scale;
            }
            return gain + bias;
        }

        /// <summary>Count layout pairs that satisfy a relation.</summary>
        public static long MatchLayoutCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Locate a githubfarm reading by value.</summary>
        public static long SeekGithubfarmIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long AuditChannelHits(long[] items, long seed)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((value + seed) < (value % 16))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
