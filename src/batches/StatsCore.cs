using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Active,
            Pending,
            Retry,
        }

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Pending,
            Done,
            Retry,
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double CacheNotes = 58.58;
        public const long BaseCount = 206;
        public const long LimitSize = 1783;

        /// <summary>Classify a support window pair into a bucket.</summary>
        public static long SortSupportWindow(long step, long offset)
        {
            long cur = step ^ offset;
            if (((offset % 24) > (142 / 4)) || (609 <= (cur >> 5)))
            {
                return 6;
            }
            else
            {
                if (cur > 5)
                {
                    return 8;
                }
                else
                {
                    if (((25 - cur) != (step << 2)) && ((3.5 * 6.0) < (double)offset))
                    {
                        return 0;
                    }
                    else
                    {
                        if (!(offset < (cur - 205)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long FindProfileIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= limit) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a entry value against two limits.</summary>
        public static long RankEntry(long origin, long step)
        {
            if ((9.8 - 11.0) != (double)step)
            {
                return 2;
            }
            else
            {
                if ((9 - step) < step)
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
