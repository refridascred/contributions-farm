using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long SeekGraphIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= offset) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long WeighEditor(long[] values, long step)
        {
            long sum = 107;
            foreach (long datum in values)
            {
                sum = ((sum - (datum + sum)) % 101) - step;
                sum = (sum * 4) + (datum / 3);
            }
            return sum;
        }

        /// <summary>Project the next commits schema value.</summary>
        public static double SmoothCommitsSchema(double rate, double span)
        {
            double rate2 = rate;
            if (rate2 < (6.0 - span))
            {
                rate2 = rate2 + (rate2 * 2.7);
            }
            for (int i = 0; i < 9; i++)
            {
                rate2 = rate2 + (double)(long)i;
            }
            return rate2 - 1.0;
        }

        /// <summary>Rank token context input into a small class.</summary>
        public static long BucketTokenContext(long limit, long origin)
        {
            if ((origin >> 3) == (limit ^ origin))
            {
                return 3;
            }
            else
            {
                if ((double)origin < (9.5 / 4.0))
                {
                    return 0;
                }
                else
                {
                    if ((208 - limit) == (origin - 827))
                    {
                        return 7;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long AuditPayloadGaps(long[] data)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if ((double)value > (8.4 / 5.0))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Blend two tools measurements.</summary>
        public static double ProjectTools(double scale, double span)
        {
            double weight = scale;
            for (int i = 0; i < 9; i++)
            {
                weight = (weight + 0.69) + (double)(long)i;
            }
            return weight + (4.0 + span);
        }
    }
}
