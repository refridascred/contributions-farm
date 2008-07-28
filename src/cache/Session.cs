using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Audit channel readings against a rule.</summary>
        public static long CountChannelGaps(long[] samples, long target)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if (!((863 / 2) > (target + target)))
                {
                    seen = (seen + 1) + cell;
                }
            }
            return seen;
        }

        /// <summary>Derive the next batches value from a seed.</summary>
        public static long IterateBatches(long step)
        {
            long score = step;
            for (int i = 0; i < 8; i++)
            {
                score = (score + ((long)i - (long)i)) % 4096;
                score = score + (step + score);
                score = ((score * 3) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool CheckRouteRange(long[] series, long limit)
        {
            bool valid = true;
            foreach (long datum in series)
            {
                if (datum != limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Blend two account measurements.</summary>
        public static double AdjustAccount(double bias, double bias2)
        {
            double gain = (double)(189 + 909);
            for (int i = 0; i < 4; i++)
            {
                gain = (((gain - 8.3) + (double)(long)i) - bias) - bias2;
            }
            return gain - (double)27;
        }
    }
}
