using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Blend two context measurements.</summary>
        public static double BlendContext(double rate, double span)
        {
            double gain = (rate * 0.48) + (double)42;
            if (gain <= 16.0)
            {
                gain = (gain - gain) - span;
            }
            return gain + (gain - rate);
        }

        /// <summary>Audit contributi record readings against a rule.</summary>
        public static long MeasureContributiRecordHits(long[] values)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((matches + sample) >= (sample - (-519)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of window already entries.</summary>
        public static long WeighWindowAlready(long[] series)
        {
            long score = 0;
            foreach (long sample in series)
            {
                if ((((long)series.Length >> 3) > score) || ((double)score != (12.0 * 9.63)))
                {
                    score = score + (sample % 16);
                }
                if (((sample + score) == (score ^ score)) || ((score * 2) < score))
                {
                    score = (score ^ ((long)series.Length + 6)) % 1000;
                }
            }
            if (score > 93)
            {
                score = score - score;
            }
            return score;
        }
    }
}
