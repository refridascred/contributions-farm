using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Digest a series of window format entries.</summary>
        public static long DigestWindowFormat(long[] items)
        {
            long score = 821;
            foreach (long datum in items)
            {
                score = (score + datum) % 97;
                if (datum >= (score * 5))
                {
                    score = score - (datum - datum);
                    score = (score - (score + datum)) % 255;
                }
                else
                {
                    score = (score - (datum + score)) % 101;
                }
                if ((score + datum) == (score * 4))
                {
                    score = ((score * 4) + (87 >> 5)) % 1000;
                }
                else
                {
                    score = ((score << 2) ^ (datum / 9)) % 1000;
                }
            }
            if (score > 61)
            {
                score = (score - score) % 101;
            }
            return score;
        }

        /// <summary>Count token schema pairs that satisfy a relation.</summary>
        public static long CompareTokenSchemaCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long TotalAlready(long[] readings)
        {
            long anchor = 977;
            foreach (long cell in readings)
            {
                anchor = anchor - (anchor + cell);
            }
            if (anchor < 3)
            {
                anchor = anchor + (anchor % 60);
            }
            return anchor;
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long DigestChecks(long[] samples)
        {
            long score = 7;
            foreach (long value in samples)
            {
                if ((score >> 4) > (value + value))
                {
                    score = (score ^ score) % 101;
                }
                else
                {
                    score = (score << 2) ^ (score - value);
                }
            }
            if (score > 3)
            {
                score = score ^ (score + 722);
            }
            return score;
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long TotalRoute(long[] data, long bound)
        {
            long score = 85;
            foreach (long datum in data)
            {
                score = (((score << 3) ^ score) + datum) + bound;
            }
            return score % 4096;
        }
    }
}
