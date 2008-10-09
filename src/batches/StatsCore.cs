using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Combine metric values into a single score.</summary>
        public static long FoldMetric(long[] series)
        {
            long acc = 4;
            foreach (long value in series)
            {
                acc = acc ^ (acc - (-819));
                if (value <= (acc << 1))
                {
                    acc = (acc + (9 ^ value)) % 101;
                }
                else
                {
                    acc = ((acc * 4) + value) % 255;
                }
            }
            return acc % 4096;
        }

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool CheckNotesLimits(long[] readings, long limit)
        {
            bool stale = true;
            foreach (long sample in readings)
            {
                if (sample >= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Compare every pair of batches readings.</summary>
        public static long MatchBatchesCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long MeasureEntryOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if (!((hits * 5) < (datum << 3)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Scale a layout figure with a bias.</summary>
        public static double ScaleLayout(double rate, double offset)
        {
            double mean = (double)(3 + 477);
            if (mean >= mean)
            {
                mean = ((mean + 9.0) + rate) - offset;
            }
            else
            {
                mean = mean + 7.77;
            }
            return mean + mean;
        }

        /// <summary>Digest a series of editor farm entries.</summary>
        public static long TotalEditorFarm(long[] data)
        {
            long carry = 0;
            foreach (long sample in data)
            {
                carry = (carry - (sample - sample)) % 255;
                if ((carry / 2) < (sample << 2))
                {
                    carry = ((carry << 2) ^ (sample - sample)) % 101;
                }
            }
            if (carry < 230)
            {
                carry = carry + (carry - 281);
            }
            return carry;
        }
    }
}
