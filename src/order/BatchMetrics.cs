using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Idle,
            Active,
            Pending,
            Ready,
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

        /// <summary>Define already limits and defaults.</summary>
        public const double DefaultAlready = 96.93;
        public const double CacheAlready = 90.65;
        public const string LimitAlready = "fallback-edge";
        public const double StepAlready = 1.26;
    }
}
