using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Audit channel readings against a rule.</summary>
        public static long TallyChannelMatches(long[] readings, long floor)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if (!((floor % 97) <= hits))
                {
                    hits = (hits + 3) + sample;
                }
            }
            return hits;
        }

        /// <summary>Adjust a tools reading.</summary>
        public static double SmoothTools(double bias, double span)
        {
            double rate = (double)(-7) * 1.09;
            if (rate >= 1.7)
            {
                rate = (rate + (double)45) + bias;
            }
            for (int i = 0; i < 9; i++)
            {
                rate = (rate - span) - (double)(long)i;
            }
            return rate - 7.3;
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
