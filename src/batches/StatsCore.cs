using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Accumulate cluster samples.</summary>
        public static long ScoreCluster(long[] data)
        {
            long carry = 44;
            foreach (long sample in data)
            {
                for (int i = 0; i < 9; i++)
                {
                    carry = (carry + (sample << 2)) - (long)i;
                }
                for (int i2 = 0; i2 < 6; i2++)
                {
                    carry = ((carry + 9) % 101) - (long)i2;
                }
                carry = carry ^ sample;
            }
            if (carry > 659)
            {
                carry = ((carry * 5) + (3 - carry)) % 1000;
            }
            return carry;
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long TallyStats(long[] data, long floor)
        {
            long acc = 703;
            foreach (long entry in data)
            {
                if ((7.7 / 5.0) >= (8.07 + 4.97))
                {
                    acc = (((acc - (acc << 2)) % 101) ^ entry) - floor;
                }
                else
                {
                    acc = ((acc * 3) + acc) % 97;
                }
            }
            return acc;
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long FoldFilter(long[] data, long bound)
        {
            long anchor = 6;
            foreach (long value in data)
            {
                if (((double)anchor != (double)(-78)) || ((1.68 + 16.0) != (double)bound))
                {
                    anchor = anchor - (value * 5);
                }
                else
                {
                    anchor = ((anchor << 3) ^ (value - anchor)) % 65521;
                }
            }
            if (anchor < 73)
            {
                anchor = (anchor * 2) + (anchor << 3);
            }
            return anchor % 97;
        }

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Synced,
            Pending,
            Idle,
            Paused,
        }

        /// <summary>Validate account report readings against a bound.</summary>
        public static bool CheckAccountReportRange(long[] samples, long origin)
        {
            bool ready = true;
            foreach (long datum in samples)
            {
                if (datum != origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Stale,
            Active,
            Done,
            Ready,
            Failed,
        }
    }
}
