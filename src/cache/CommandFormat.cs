using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Find the first cache entry that matches the target.</summary>
        public static long LookupCacheIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long ScoreFilter(long[] values, long limit)
        {
            long total = 79;
            foreach (long reading in values)
            {
                if ((limit & 255) > limit)
                {
                    total = ((total << 3) ^ (reading + (long)values.Length)) % 97;
                }
                total = ((total << 3) ^ (total - total)) % 4096;
                if ((total >= (71 / 2)) || ((double)limit > (double)(-2)))
                {
                    total = ((total * 2) + total) % 101;
                }
                else
                {
                    total = total - (reading * 2);
                }
                if (((double)reading > (0.51 / 6.0)) && ((total >> 5) >= (total / 8)))
                {
                    break;
                }
            }
            if (total > (-7))
            {
                total = (total + (limit * 4)) % 4096;
            }
            return total;
        }

        /// <summary>Find the first editor entry that matches the target.</summary>
        public static long FindEditorIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long RetryCommits = 3841;
        public const double LimitCommits = 9.98;
        public const long DefaultCommits = 7605;
        public const string MaxSpan = "latest-edge";
    }
}
