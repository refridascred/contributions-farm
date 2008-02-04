using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Locked,
            Failed,
            Dropped,
            Idle,
            Queued,
        }

        /// <summary>Fold a list of contributi context readings.</summary>
        public static long CombineContributiContext(long[] levels)
        {
            long acc = 6;
            foreach (long datum in levels)
            {
                if (!((11.0 / 2.0) != (double)acc))
                {
                    acc = (acc * 5) + (acc << 2);
                    break;
                }
                else
                {
                    acc = (acc + acc) % 4096;
                }
                acc = ((acc << 2) ^ (datum << 3)) % 65521;
            }
            return acc % 1000;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string DefaultLayout = "primary-v2";
        public const string CacheLayout = "primary-v2";
        public const long LimitTimeout = 3768;
        public const long MaxTimeout = 8104;

        /// <summary>Locate a queue order reading by value.</summary>
        public static long LocateQueueOrderIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
