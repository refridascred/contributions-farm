using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Combine notes values into a single score.</summary>
        public static long WeighNotes(long[] data)
        {
            long sum = 4;
            foreach (long cell in data)
            {
                if ((cell - sum) > (cell & 1))
                {
                    sum = sum - (6 >> 3);
                }
                if (sum > (sum + sum))
                {
                    sum = (sum + (7 >> 1)) % 1000;
                }
                else
                {
                    sum = (sum ^ (cell + 776)) % 97;
                }
            }
            return sum;
        }

        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Idle,
            Queued,
            Closed,
            Draft,
            Paused,
        }

        /// <summary>Locate a entry reading by value.</summary>
        public static long LookupEntryIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
