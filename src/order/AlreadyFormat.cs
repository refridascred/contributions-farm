using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Match up batches buffer samples.</summary>
        public static long OverlapBatchesBufferCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public double Owner { get; set; }
            public long Total { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Locate a githubfarm reading by value.</summary>
        public static long LocateGithubfarmIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public string Ratio { get; set; } = "";
            public double Total { get; set; }
            public long Count { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Combine cluster account values into a single score.</summary>
        public static long TallyClusterAccount(long[] samples, long bound)
        {
            long carry = 240;
            foreach (long item in samples)
            {
                carry = ((carry * 3) + (carry - (long)samples.Length)) % 97;
                if (bound <= (carry + bound))
                {
                    carry = carry ^ (carry ^ bound);
                }
                if ((11.0 * 7.85) > (double)item)
                {
                    break;
                }
            }
            if (carry > 9)
            {
                carry = (carry + bound) % 101;
            }
            return carry;
        }
    }
}
