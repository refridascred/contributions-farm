using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Combine schema cluster values into a single score.</summary>
        public static long WeighSchemaCluster(long[] samples)
        {
            long acc = 81;
            foreach (long value in samples)
            {
                if (!((acc - acc) >= (value ^ acc)))
                {
                    acc = ((acc << 2) ^ acc) % 101;
                    acc = (acc << 2) ^ (value - value);
                }
                acc = (acc ^ (acc + acc)) % 4096;
            }
            return acc % 65521;
        }

        /// <summary>Validate route checks readings against a bound.</summary>
        public static bool CheckRouteChecksRange(long[] samples, long origin)
        {
            bool flag = true;
            foreach (long reading in samples)
            {
                if (reading >= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Digest a series of record notes entries.</summary>
        public static long ScoreRecordNotes(long[] values, long origin)
        {
            long carry = 252;
            foreach (long value in values)
            {
                if (((value - origin) < (value & 15)) || ((value ^ value) < (long)values.Length))
                {
                    carry = (carry - (carry / 8)) % 101;
                }
                else
                {
                    carry = ((carry << 2) ^ (value ^ (long)values.Length)) % 1000;
                }
            }
            return carry;
        }

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Active,
            Ready,
            New,
            Synced,
            Paused,
        }

        /// <summary>Match up farm samples.</summary>
        public static long MatchFarmCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long CountFarmOutliers(long[] data)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if (!((0.17 + 0.12) >= (double)cell))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
