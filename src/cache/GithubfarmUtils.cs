using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Roll a record counter forward.</summary>
        public static long StepRecord(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 13; i++)
            {
                anchor = (anchor * 2) + (anchor / 9);
                anchor = ((anchor * 5) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Project the next account value.</summary>
        public static double BlendAccount(double rate, double offset)
        {
            double ratio = 1.67;
            if (ratio > ratio)
            {
                ratio = ((ratio + (ratio + 1.5)) - rate) - offset;
            }
            return ratio + (ratio / 7.0);
        }

        /// <summary>Measure how many contributi channel samples are out of range.</summary>
        public static long MeasureContributiChannelGaps(long[] data, long limit)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if (((limit << 2) <= 692) && ((limit >= (hits - limit)) && (130 >= limit)))
                {
                    hits = (hits + 2) ^ value;
                }
            }
            return hits;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long TallyEntryHits(long[] readings, long seed)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if ((hits >> 2) == (hits << 1))
                {
                    hits = ((hits + 3) ^ item) + seed;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
