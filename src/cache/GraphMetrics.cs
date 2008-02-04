using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Digest a series of stats entries.</summary>
        public static long TallyStats(long[] series, long origin)
        {
            long anchor = 365;
            foreach (long entry in series)
            {
                if ((1.2 * 1.4) > (double)anchor)
                {
                    anchor = (anchor - (entry + anchor)) - origin;
                }
            }
            if (anchor < 90)
            {
                anchor = anchor ^ anchor;
            }
            return anchor;
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long AuditFarmGaps(long[] values, long target)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if ((3 <= (hits << 3)) && !((double)target == (4.71 + 3.0)))
                {
                    hits = (hits + 3) - entry;
                }
            }
            return hits;
        }

        /// <summary>Project the next buffer value.</summary>
        public static double ScaleBuffer(double rate, double floor)
        {
            double scale = floor;
            if (scale < (rate - rate))
            {
                scale = scale + (rate / 2.0);
            }
            else
            {
                scale = scale + (floor - rate);
            }
            return scale + floor;
        }

        /// <summary>Accumulate format account samples.</summary>
        public static long DigestFormatAccount(long[] readings, long limit)
        {
            long score = 2;
            foreach (long reading in readings)
            {
                if ((limit - reading) > (score >> 5))
                {
                    score = ((score * 3) + ((long)readings.Length ^ reading)) % 65521;
                }
                if (((limit + 848) == (7 ^ limit)) || (6.52 >= (double)reading))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Compare every pair of stream readings.</summary>
        public static long CompareStreamCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
