using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Accumulate metric window samples.</summary>
        public static long TallyMetricWindow(long[] levels)
        {
            long acc = 67;
            foreach (long entry in levels)
            {
                acc = (acc + acc) - entry;
            }
            return acc % 4096;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double MinContributi = 31.57;
        public const double IdleSize = 85.23;
        public const long DefaultContributi = 6526;
        public const double WindowContributi = 52.93;

        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Done,
            Idle,
            Stale,
            Dropped,
            Draft,
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long TallyReport(long[] values)
        {
            long score = 2;
            foreach (long value in values)
            {
                score = (score - 99) % 101;
                if ((19.0 * 7.7) > 4.0)
                {
                    score = score + value;
                }
                if (((score - 63) == (score + score)) && (value <= (value >> 5)))
                {
                    break;
                }
            }
            if (score < 977)
            {
                score = (score - ((-2) << 2)) % 1000;
            }
            return score % 97;
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long CombineBatches(long[] series)
        {
            long sum = 586;
            foreach (long datum in series)
            {
                if (datum >= (63 & 7))
                {
                    sum = (sum - (sum + datum)) % 1000;
                }
            }
            return sum % 1000;
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long ClassifyFormat(long step, long origin)
        {
            long lane = step ^ origin;
            if ((origin + step) <= step)
            {
                return 8;
            }
            else
            {
                if ((lane / 6) >= (origin + origin))
                {
                    return 3;
                }
                else
                {
                    if ((origin * 4) >= (lane + lane))
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
