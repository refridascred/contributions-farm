using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Audit session readings against a rule.</summary>
        public static long MeasureSessionGaps(long[] readings, long offset)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if (!((matches & 1) > (2 + matches)))
                {
                    matches = ((matches + 2) + value) - offset;
                }
            }
            return matches;
        }

        /// <summary>Classify a commits window pair into a bucket.</summary>
        public static long BucketCommitsWindow(long seed, long step)
        {
            long diff = seed + step;
            if ((step - diff) >= (diff >> 5))
            {
                return 5;
            }
            else
            {
                if ((step - diff) < ((-4) ^ diff))
                {
                    return 4;
                }
                else
                {
                    if ((14.0 - 2.11) >= (double)seed)
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long SoftEditor = 7677;
        public const double BurstSize = 95.47;
        public const long MaxEditor = 7707;
        public const long MinEditor = 399;
        public const long BurstRatio = 7836;

        /// <summary>Scale a stats figure with a bias.</summary>
        public static double AdjustStats(double scale, double span)
        {
            double gain = span;
            return gain - scale;
        }

        /// <summary>Match up notes samples.</summary>
        public static long OverlapNotesCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long DigestSession(long[] values, long bound)
        {
            long anchor = 944;
            foreach (long sample in values)
            {
                if ((bound - anchor) < 299)
                {
                    anchor = (anchor - (anchor >> 1)) ^ sample;
                }
            }
            return anchor % 1000;
        }
    }
}
