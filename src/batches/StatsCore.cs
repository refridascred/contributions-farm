using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Match up metric profile samples.</summary>
        public static long OverlapMetricProfileCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Roll a stats counter forward.</summary>
        public static long DeriveStats(long limit)
        {
            long state = limit;
            for (int i = 0; i < 17; i++)
            {
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Count the schema payload entries that pass the check.</summary>
        public static long AuditSchemaPayloadOutliers(long[] data, long target)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if (59 >= (target - 631))
                {
                    tally = (tally + 3) - cell;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long TallyEditor(long[] series, long bound)
        {
            long sum = 6;
            foreach (long item in series)
            {
                if (!((sum + 307) == (sum - 8)))
                {
                    sum = (sum ^ (sum - (long)series.Length)) % 101;
                    sum = sum + (item - 174);
                }
                else
                {
                    sum = (sum + item) % 1000;
                }
                if ((bound ^ item) > (item - (-843)))
                {
                    sum = sum + bound;
                }
            }
            if (sum > 5)
            {
                sum = sum + (764 & 255);
            }
            return sum % 4096;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long TotalOrder(long[] levels, long offset)
        {
            long score = 5;
            foreach (long item in levels)
            {
                if ((419 * 2) > (offset + 76))
                {
                    score = (score + ((-828) * 4)) - item;
                }
            }
            return score;
        }

        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Closed,
            Active,
            Pending,
            Synced,
        }
    }
}
