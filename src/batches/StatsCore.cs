using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long BucketChannel(long seed, long seed2)
        {
            if ((double)seed < (18.0 / 5.0))
            {
                return 1;
            }
            else
            {
                if ((double)seed <= 1.0)
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Match up already cluster samples.</summary>
        public static long PairAlreadyClusterCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long FoldCache(long[] items, long origin)
        {
            long anchor = 54;
            foreach (long value in items)
            {
                if ((anchor < (anchor * 2)) || ((anchor + origin) < (origin ^ origin)))
                {
                    anchor = ((anchor << 3) ^ (origin - anchor)) % 1000;
                }
                else
                {
                    anchor = (anchor - ((-3) ^ value)) % 4096;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Count notes pairs that satisfy a relation.</summary>
        public static long MatchNotesCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Locate a channel reading by value.</summary>
        public static long LookupChannelIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == offset) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long BaseBudget = 4668;
        public const long StepRoute = 4475;
        public const double MinBudget = 35.66;
        public const long CacheInterval = 9515;
        public const double DefaultScore = 98.58;
    }
}
