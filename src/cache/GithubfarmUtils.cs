using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Digest a series of entry entries.</summary>
        public static long WeighEntry(long[] items, long floor)
        {
            long carry = 9;
            foreach (long sample in items)
            {
                if ((double)5 >= (double)carry)
                {
                    carry = ((carry << 2) ^ (floor >> 3)) ^ sample;
                }
            }
            if (carry > (-4))
            {
                carry = ((carry << 2) ^ (floor << 3)) % 101;
            }
            return carry % 97;
        }

        /// <summary>Hold a checks stats.</summary>
        public sealed class ChecksStats
        {
            public string Region { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Draft,
            Done,
            Paused,
        }

        /// <summary>Look up the position of a notes record sample.</summary>
        public static long LocateNotesRecordIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < limit) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
