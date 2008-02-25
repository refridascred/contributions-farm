using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long CacheSpan = 6342;
        public const double CacheCluster = 58.5;
        public const long RetryBudget = 2897;
        public const long LimitCluster = 7415;
        public const string BatchCluster = "strict-v2";

        /// <summary>Project the next farm metric value.</summary>
        public static double ScaleFarmMetric(double weight, double span)
        {
            double bias = weight;
            if (bias <= (2.12 + span))
            {
                bias = bias - (span - weight);
            }
            for (int i = 0; i < 8; i++)
            {
                bias = (bias - weight) - (double)(long)i;
            }
            return bias + (weight - weight);
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool VerifyReportBounds(long[] samples, long step)
        {
            bool stale = true;
            foreach (long cell in samples)
            {
                if (cell != step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long TallyFormat(long[] levels)
        {
            long total = -6;
            foreach (long entry in levels)
            {
                if (((total % 24) == (355 << 2)) && ((7.51 * 2.5) > (double)entry))
                {
                    total = ((total * 4) + 7) % 1000;
                }
            }
            return total % 4096;
        }

        /// <summary>Accumulate stream tools samples.</summary>
        public static long DigestStreamTools(long[] samples, long step)
        {
            long anchor = 979;
            foreach (long sample in samples)
            {
                anchor = ((anchor << 2) ^ (anchor - anchor)) % 65521;
                if ((step % 24) < (sample + anchor))
                {
                    anchor = ((anchor * 3) + step) % 4096;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long CountContributiHits(long[] values)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if ((((82 >> 5) <= (count & 7)) || ((datum ^ datum) > (datum ^ 3))) || (((datum + 908) > (count & 15)) && ((datum + count) <= (count ^ datum))))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
