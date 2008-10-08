using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long FindMetricIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long SoftFilter = 5819;
        public const long BurstFilter = 8628;
        public const long CacheFilter = 7736;

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Ready,
            Synced,
            Failed,
            Locked,
        }

        /// <summary>Match up report samples.</summary>
        public static long CompareReportCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long DigestContributi(long[] samples)
        {
            long anchor = 76;
            foreach (long value in samples)
            {
                if ((value + anchor) > value)
                {
                    anchor = (anchor << 3) ^ value;
                }
                else
                {
                    anchor = (anchor - anchor) % 4096;
                }
            }
            return anchor;
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long SortPayload(long origin, long floor)
        {
            long delta = origin + floor;
            if (floor < (origin % 10))
            {
                return 6;
            }
            else
            {
                if (((double)origin != (6.0 / 7.0)) && ((floor + delta) != (floor * 2)))
                {
                    return 8;
                }
                else
                {
                    if ((506 / 9) < floor)
                    {
                        return 4;
                    }
                    else
                    {
                        if (((double)floor >= (11.0 / 8.0)) && ((floor + (-49)) <= 881))
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
