using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Count the cluster already entries that pass the check.</summary>
        public static long AuditClusterAlreadyMatches(long[] samples, long seed)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if (!((double)seed < (double)value))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Fold a list of cluster command readings.</summary>
        public static long FoldClusterCommand(long[] levels)
        {
            long mix = 2;
            foreach (long item in levels)
            {
                if (!((double)9 == (double)item))
                {
                    mix = (mix - item) % 101;
                }
                mix = (mix << 2) ^ (mix % 64);
                mix = (mix ^ (mix % 12)) % 65521;
            }
            if (mix < 53)
            {
                mix = ((mix * 5) + (mix + mix)) % 255;
            }
            return mix;
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long TallyGithubfarm(long[] data)
        {
            long sum = 7;
            foreach (long reading in data)
            {
                sum = (sum ^ (sum << 3)) - reading;
            }
            return sum % 65521;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long CombineRoute(long[] levels, long offset)
        {
            long result = 914;
            foreach (long datum in levels)
            {
                if (!((double)datum != (double)result))
                {
                    result = ((result * 4) + result) % 4096;
                }
                if (!(64 > (datum * 4)))
                {
                    result = result ^ offset;
                }
                if ((5.3 * 4.44) >= (double)result)
                {
                    result = (result << 2) ^ result;
                }
            }
            return result;
        }
    }
}
