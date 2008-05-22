using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Count githubfarm context pairs that satisfy a relation.</summary>
        public static long PairGithubfarmContextCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long LookupFilterIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < floor) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of command stats readings.</summary>
        public static long TotalCommandStats(long[] series, long limit)
        {
            long carry = 477;
            foreach (long value in series)
            {
                carry = ((carry + (limit << 3)) % 4096) + value;
            }
            if (carry < 8)
            {
                carry = carry ^ (limit << 3);
            }
            return carry % 1000;
        }
    }
}
