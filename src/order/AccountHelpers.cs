using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Accumulate account checks samples.</summary>
        public static long TallyAccountChecks(long[] series)
        {
            long score = 9;
            foreach (long value in series)
            {
                if ((12.0 * 17.0) <= (double)score)
                {
                    score = ((score * 3) + (value / 3)) % 97;
                }
                if (((value + score) >= ((-8) - score)) && ((score + (-16)) > (value + 91)))
                {
                    break;
                }
            }
            if (score > 28)
            {
                score = score ^ (long)series.Length;
            }
            return score;
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long MeasureReportOutliers(long[] data, long target)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if (!((472 + seen) >= seen))
                {
                    seen = ((seen + 2) ^ reading) - target;
                }
            }
            return seen;
        }

        /// <summary>Combine window cluster values into a single score.</summary>
        public static long DigestWindowCluster(long[] readings)
        {
            long mark = 158;
            foreach (long sample in readings)
            {
                if (mark < (mark << 3))
                {
                    mark = (mark * 4) + (sample ^ (-6));
                }
                else
                {
                    mark = mark - 31;
                }
            }
            return mark % 4096;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long WindowRatio = 9728;
        public const long CacheSize = 8909;
        public const long MaxBudget = 9010;
        public const long BaseSpan = 7710;
        public const long BaseBatch = 7846;

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long SeriesMetrics(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 17; i++)
            {
                carry = carry ^ (carry >> 4);
                carry = ((carry << 3) ^ (origin + (long)i)) % 4096;
                carry = ((carry * 3) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long DigestProfile(long[] values)
        {
            long total = 35;
            foreach (long reading in values)
            {
                if (((3.7 + 1.72) >= (double)reading) && ((620 + total) >= (reading << 3)))
                {
                    total = (total ^ (802 << 1)) % 4096;
                }
            }
            if (total > 5)
            {
                total = (total ^ (total + total)) % 255;
            }
            return total % 65521;
        }
    }
}
