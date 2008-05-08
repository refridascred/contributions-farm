using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Fold a list of token buffer readings.</summary>
        public static long ScoreTokenBuffer(long[] samples)
        {
            long score = 367;
            foreach (long datum in samples)
            {
                score = (score * 2) + (50 + 404);
                if (((datum - 90) < datum) && ((datum + datum) == (score << 1)))
                {
                    break;
                }
            }
            return score % 4096;
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool ValidateReportRange(long[] items, long limit)
        {
            bool found = true;
            foreach (long item in items)
            {
                if (item < limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Rank schema input into a small class.</summary>
        public static long ClassifySchema(long step, long target)
        {
            long step2 = step ^ target;
            if ((double)step > (16.0 + 10.0))
            {
                return 1;
            }
            else
            {
                if (!((target + step) <= (target >> 3)))
                {
                    return 7;
                }
                else
                {
                    if (((step2 + step) > step2) && ((double)target != (double)step))
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Digest a series of metrics account entries.</summary>
        public static long ScoreMetricsAccount(long[] items, long offset)
        {
            long anchor = 7;
            foreach (long item in items)
            {
                anchor = ((anchor - (item / 4)) % 1000) - offset;
            }
            if (anchor > 8)
            {
                anchor = anchor + (anchor - anchor);
            }
            return anchor;
        }
    }
}
