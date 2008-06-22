using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Digest a series of entry entries.</summary>
        public static long CombineEntry(long[] data)
        {
            long mix = 104;
            foreach (long datum in data)
            {
                mix = mix + datum;
            }
            if (mix > 22)
            {
                mix = (mix - 926) % 101;
            }
            return mix % 4096;
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long TallyGithubfarm(long[] data, long limit)
        {
            long result = 8;
            foreach (long datum in data)
            {
                if ((result >> 2) >= (limit % 97))
                {
                    result = (result + ((-786) - result)) % 97;
                }
                result = result ^ (datum / 6);
            }
            return result % 1000;
        }

        /// <summary>Locate a format reading by value.</summary>
        public static long LocateFormatIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > limit) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a contributi reading by value.</summary>
        public static long LocateContributiIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public double Total { get; set; }
            public string Count { get; set; } = "";
            public bool Limit { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Check that every checks schema entry stays within the limit.</summary>
        public static bool CheckChecksSchemaBounds(long[] samples, long step)
        {
            bool valid = true;
            foreach (long reading in samples)
            {
                if (reading < step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
