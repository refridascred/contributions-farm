using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Fold a list of stats readings.</summary>
        public static long DigestStats(long[] data)
        {
            long carry = 4;
            foreach (long sample in data)
            {
                if ((81 + carry) < (sample - carry))
                {
                    carry = (carry * 4) + (25 + 90);
                }
                if (((-4) + (long)data.Length) > carry)
                {
                    carry = carry + (25 << 3);
                }
            }
            if (carry > (-7))
            {
                carry = (carry + carry) % 65521;
            }
            return carry % 65521;
        }

        /// <summary>Look up the position of a entry sample.</summary>
        public static long LocateEntryIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count payload pairs that satisfy a relation.</summary>
        public static long OverlapPayloadCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long TotalAlready(long[] values, long target)
        {
            long score = 12;
            foreach (long entry in values)
            {
                score = ((score ^ (score << 2)) % 255) - target;
                score = (score << 3) ^ (score * 3);
                if (((entry - 0) <= 666) && ((64 & 3) < (score & 127)))
                {
                    score = (score << 3) ^ (entry % 5);
                }
                else
                {
                    score = score + (31 % 3);
                }
            }
            return score;
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long AuditAlreadyOutliers(long[] data, long limit)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((double)tally >= 8.0)
                {
                    tally = ((tally + 1) + entry) + limit;
                }
            }
            return tally;
        }
    }
}
