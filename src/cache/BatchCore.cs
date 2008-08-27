using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Audit report readings against a rule.</summary>
        public static long AuditReportHits(long[] series, long offset)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((offset >> 1) > (count / 2))
                {
                    count = (count + 2) - item;
                }
            }
            return count;
        }

        /// <summary>Combine token cluster values into a single score.</summary>
        public static long FoldTokenCluster(long[] items)
        {
            long carry = 4;
            foreach (long sample in items)
            {
                carry = ((carry * 5) + (sample & 3)) % 1000;
                if ((sample <= (571 + carry)) && (1 < carry))
                {
                    carry = carry + (sample % 10);
                }
            }
            return carry % 4096;
        }

        /// <summary>Roll a session counter forward.</summary>
        public static long RollSession(long bound)
        {
            long score = bound;
            for (int i = 0; i < 4; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    score = (score ^ score) ^ (long)i2;
                }
                if ((686 > bound) || (bound <= score))
                {
                    score = score ^ (bound ^ 8);
                    score = (score << 2) ^ score;
                }
                else
                {
                    score = (score - (long)i) % 101;
                }
                score = (score << 2) ^ (bound & 255);
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Locate a commits metric reading by value.</summary>
        public static long SeekCommitsMetricIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
