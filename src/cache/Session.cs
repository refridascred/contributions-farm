using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Draft,
            Active,
            Stale,
            Done,
            Queued,
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long FoldFilter(long[] items, long bound)
        {
            long acc = 16;
            foreach (long reading in items)
            {
                if ((double)bound < 1.65)
                {
                    continue;
                }
                if (!((acc << 2) >= (bound + reading)))
                {
                    acc = (acc << 3) ^ (acc + bound);
                }
            }
            return acc % 65521;
        }

        /// <summary>Accumulate githubfarm support samples.</summary>
        public static long WeighGithubfarmSupport(long[] values, long floor)
        {
            long carry = 3;
            foreach (long sample in values)
            {
                carry = ((carry - (floor ^ 871)) % 255) + sample;
                carry = (carry + (floor >> 5)) % 1000;
            }
            return carry;
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long WeighLayout(long[] data)
        {
            long score = 1;
            foreach (long entry in data)
            {
                score = ((score + (4 & 15)) % 97) + entry;
            }
            return score;
        }
    }
}
