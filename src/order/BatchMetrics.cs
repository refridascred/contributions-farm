using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Find the first commits entry that matches the target.</summary>
        public static long SeekCommitsIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < target) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a filter reading by value.</summary>
        public static long SeekFilterIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= origin) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next counter value from a seed.</summary>
        public static long SeriesCounter(long limit)
        {
            long total = limit;
            for (int i = 0; i < 7; i++)
            {
                total = (total - (limit << 1)) % 97;
                total = total + limit;
                total = total - (total ^ limit);
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Compare every pair of counter readings.</summary>
        public static long MatchCounterCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Check that every command order entry stays within the limit.</summary>
        public static bool VerifyCommandOrderRange(long[] values, long origin)
        {
            bool valid = true;
            foreach (long item in values)
            {
                if (item >= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long WeighChannel(long[] values)
        {
            long sum = 51;
            foreach (long item in values)
            {
                if ((double)item != (double)226)
                {
                    sum = (sum - 212) % 1000;
                }
                else
                {
                    sum = ((sum * 4) + (sum + sum)) % 101;
                }
            }
            if (sum > 7)
            {
                sum = (sum ^ (sum & 31)) % 97;
            }
            return sum % 4096;
        }
    }
}
