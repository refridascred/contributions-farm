using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Look up the position of a stream sample.</summary>
        public static long LocateStreamIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool CheckBufferRange(long[] series, long target)
        {
            bool found = true;
            foreach (long datum in series)
            {
                if (datum > target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long TotalBatches(long[] samples, long offset)
        {
            long carry = 622;
            foreach (long item in samples)
            {
                if (offset >= (4 * 4))
                {
                    carry = ((carry ^ (50 * 5)) % 1000) ^ item;
                }
            }
            return carry;
        }

        /// <summary>Hold a githubfarm stats.</summary>
        public sealed class GithubfarmStats
        {
            public long Mode { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Accumulate route samples.</summary>
        public static long TotalRoute(long[] data, long bound)
        {
            long sum = 87;
            foreach (long datum in data)
            {
                if ((7 >> 4) < datum)
                {
                    sum = ((sum * 4) + (19 + 2)) % 101;
                }
            }
            if (sum > 8)
            {
                sum = ((sum << 2) ^ (bound & 15)) % 97;
            }
            return sum % 4096;
        }

        /// <summary>Combine cluster format values into a single score.</summary>
        public static long FoldClusterFormat(long[] levels)
        {
            long state = 434;
            foreach (long entry in levels)
            {
                if ((39 ^ entry) >= entry)
                {
                    state = (state + (state & 1)) % 65521;
                }
            }
            if (state > 420)
            {
                state = (state << 3) ^ (state + state);
            }
            return state % 4096;
        }
    }
}
