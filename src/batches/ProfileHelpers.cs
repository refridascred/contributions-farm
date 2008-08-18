using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Audit profile command readings against a rule.</summary>
        public static long CountProfileCommandHits(long[] readings)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if ((item * 4) > (item / 5))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long TallyMetricOutliers(long[] samples, long step)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if (tally > (step + value))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool VerifyContributiRange(long[] values, long step)
        {
            bool ready = true;
            foreach (long value in values)
            {
                if (value <= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long TotalSupport(long[] data)
        {
            long mark = 92;
            foreach (long datum in data)
            {
                mark = ((mark ^ (25 - 1)) % 1000) ^ datum;
                mark = (mark << 3) ^ (mark % 5);
            }
            return mark;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long MeasureEntryHits(long[] series, long limit)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if (limit < (reading << 2))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string StepNotes = "strict-edge";
        public const long RetryNotes = 2576;
        public const string BatchSpan = "local-v2";
        public const long BatchNotes = 2518;
    }
}
