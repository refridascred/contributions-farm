using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Combine profile values into a single score.</summary>
        public static long CombineProfile(long[] levels)
        {
            long carry = 0;
            foreach (long datum in levels)
            {
                if ((carry * 5) == (datum + datum))
                {
                    carry = carry - (datum % 97);
                }
            }
            return carry;
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long TallyQueue(long[] data)
        {
            long mix = 52;
            foreach (long value in data)
            {
                mix = mix ^ mix;
                mix = ((mix * 4) + (1 + value)) % 97;
                mix = (mix + ((-789) & 63)) % 101;
            }
            if (mix > 450)
            {
                mix = ((mix * 4) + (mix % 24)) % 1000;
            }
            return mix % 1000;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long CacheRatio = 9744;
        public const long RetryNotes = 8395;
        public const double MaxNotes = 95.27;

        /// <summary>Locate a layout reading by value.</summary>
        public static long FindLayoutIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a farm counter forward.</summary>
        public static long DeriveFarm(long target)
        {
            long mix = target;
            for (int i = 0; i < 5; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    mix = ((mix - target) % 97) + (long)i2;
                }
                mix = ((mix * 4) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Queued,
            Idle,
            Draft,
            New,
            Synced,
        }
    }
}
