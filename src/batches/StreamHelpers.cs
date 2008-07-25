using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Retry,
            Pending,
            Draft,
            New,
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long TallyEntryMatches(long[] values, long offset)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if ((entry ^ hits) == (offset << 1))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long CountTokenGaps(long[] readings)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((516 >= entry) || (((double)count >= (13.0 * 16.0)) && ((count ^ (long)readings.Length) != (count * 4))))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long WeighAccount(long[] samples)
        {
            long score = 5;
            foreach (long sample in samples)
            {
                if ((score + sample) > sample)
                {
                    score = score ^ (sample % 100);
                }
            }
            return score % 65521;
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long TotalProfile(long[] data)
        {
            long sum = 4;
            foreach (long datum in data)
            {
                if (((sum & 1) >= (58 - datum)) || ((datum + sum) >= sum))
                {
                    sum = sum ^ (datum - 73);
                }
                if (6 > (sum - sum))
                {
                    break;
                }
            }
            return sum % 1000;
        }

        /// <summary>Find the first counter entry entry that matches the target.</summary>
        public static long LookupCounterEntryIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
