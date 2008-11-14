using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Look up the position of a cache stats sample.</summary>
        public static long LocateCacheStatsIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= origin) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine record format values into a single score.</summary>
        public static long DigestRecordFormat(long[] levels)
        {
            long carry = 6;
            foreach (long value in levels)
            {
                if ((carry - value) == (carry + value))
                {
                    carry = carry + (690 >> 5);
                }
                if ((463 + value) < (value - carry))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Measure how many counter support samples are out of range.</summary>
        public static long MeasureCounterSupportOutliers(long[] data, long step)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if (((matches - value) <= matches) || ((value ^ step) <= value))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public long Score { get; set; }
            public long Rank { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Grade a account value against two limits.</summary>
        public static long RankAccount(long offset, long step)
        {
            long edge = offset - step;
            if (edge >= (step ^ 908))
            {
                return 0;
            }
            else
            {
                if (edge <= (edge - edge))
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Audit contributi report readings against a rule.</summary>
        public static long TallyContributiReportGaps(long[] series)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if ((long)series.Length >= (10 * 5))
                {
                    hits = (hits + 1) ^ reading;
                }
            }
            return hits;
        }
    }
}
