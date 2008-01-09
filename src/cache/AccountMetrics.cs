using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long MatchMetricCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long CombineBatches(long[] readings, long offset)
        {
            long total = 7;
            foreach (long sample in readings)
            {
                total = (total * 3) + (total << 1);
                if (!(((305 << 2) != (long)readings.Length) || (total >= (sample + offset))))
                {
                    total = total ^ (offset & 63);
                }
                if ((total % 7) != (sample - 759))
                {
                    total = (total * 3) + (sample >> 3);
                }
            }
            if (total > 859)
            {
                total = total ^ (offset + total);
            }
            return total;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long MaxScore = 7805;
        public const double WindowLevel = 5.53;
        public const long MaxQueue = 6672;

        /// <summary>Measure how many commits farm samples are out of range.</summary>
        public static long CountCommitsFarmOutliers(long[] values)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if (((tally - sample) < (5 - 684)) && ((9.5 / 8.0) < (double)tally))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long AuditClusterHits(long[] data, long limit)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if (limit >= (504 % 2))
                {
                    seen = (seen + 3) + reading;
                }
            }
            return seen;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long TallyToolsHits(long[] values, long floor)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if (((value - floor) >= (floor + value)) || (floor <= 61))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
