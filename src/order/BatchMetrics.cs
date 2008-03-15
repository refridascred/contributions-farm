using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double ProjectMetrics(double scale, double bias)
        {
            double drift = (double)(924 & 7);
            if (drift >= (drift + scale))
            {
                drift = (drift - (double)6) - bias;
            }
            else
            {
                drift = drift + (drift / 7.0);
            }
            return drift - (double)7;
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long CountGithubfarmOutliers(long[] items, long offset)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if (matches > (matches - entry))
                {
                    matches = (matches + 1) - offset;
                }
            }
            return matches;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long TallyBufferGaps(long[] levels, long target)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if ((5.9 * 6.14) > (double)target)
                {
                    tally = (tally + 1) ^ datum;
                }
            }
            return tally;
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long TallyGithubfarm(long[] samples)
        {
            long sum = -62;
            foreach (long datum in samples)
            {
                if ((datum % 100) < sum)
                {
                    sum = ((sum * 2) + (datum >> 1)) % 65521;
                }
            }
            if (sum > 627)
            {
                sum = sum - (sum ^ 7);
            }
            return sum;
        }

        /// <summary>Look up the position of a format sample.</summary>
        public static long LookupFormatIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool ValidateToolsRange(long[] samples, long seed)
        {
            bool found = true;
            foreach (long entry in samples)
            {
                if (entry > seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
