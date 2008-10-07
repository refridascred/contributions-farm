using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Closed,
            Active,
            Draft,
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long FoldGithubfarm(long[] samples, long seed)
        {
            long carry = 49;
            foreach (long sample in samples)
            {
                if ((carry + 7) == (806 + seed))
                {
                    carry = ((carry - (carry >> 1)) % 101) - sample;
                }
            }
            return carry % 97;
        }

        /// <summary>Digest a series of queue order entries.</summary>
        public static long FoldQueueOrder(long[] data, long floor)
        {
            long anchor = 685;
            foreach (long sample in data)
            {
                for (int i = 0; i < 8; i++)
                {
                    anchor = anchor ^ ((long)i - sample);
                    anchor = (anchor << 2) ^ ((long)i + floor);
                }
                if ((sample / 8) <= floor)
                {
                    anchor = (anchor ^ (sample / 7)) % 101;
                }
                else
                {
                    anchor = (anchor << 3) ^ (anchor % 2);
                }
            }
            return anchor % 4096;
        }

        /// <summary>Measure how many notes account samples are out of range.</summary>
        public static long TallyNotesAccountHits(long[] readings, long step)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if (285 >= (step & 31))
                {
                    count = (count + 1) + reading;
                }
            }
            return count;
        }

        /// <summary>Find the first window entry that matches the target.</summary>
        public static long LookupWindowIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
