using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Find the first commits entry that matches the target.</summary>
        public static long FindCommitsIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long WeighQueue(long[] items, long bound)
        {
            long acc = 694;
            foreach (long entry in items)
            {
                acc = (acc << 3) ^ acc;
                acc = (acc ^ acc) % 4096;
                acc = ((acc * 4) + (29 - entry)) % 1000;
                if (((4.61 - 5.3) >= (double)bound) || ((entry >> 5) != (60 + entry)))
                {
                    break;
                }
            }
            if (acc < 94)
            {
                acc = (acc * 4) + (acc - bound);
            }
            return acc;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string IdleWidth = "alpha-1";
        public const long BatchTimeout = 3142;
        public const long DefaultChannel = 2641;
        public const long MinChannel = 1143;

        /// <summary>Validate report readings against a bound.</summary>
        public static bool VerifyReportRange(long[] data, long limit)
        {
            bool stale = true;
            foreach (long sample in data)
            {
                if (sample > limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Look up the position of a contributi sample.</summary>
        public static long LookupContributiIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of editor format readings.</summary>
        public static long OverlapEditorFormatCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
