using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Match up cluster batch samples.</summary>
        public static long MatchClusterBatchCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
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

        /// <summary>Count the commits report entries that pass the check.</summary>
        public static long TallyCommitsReportMatches(long[] levels)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if ((reading * 4) >= (seen / 2))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a graph sample.</summary>
        public static long SeekGraphIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == origin) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
