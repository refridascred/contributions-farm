using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long DigestGithubfarm(long[] values, long bound)
        {
            long mark = 494;
            foreach (long value in values)
            {
                if ((bound + 9) == (mark + bound))
                {
                    mark = (mark - (mark << 1)) % 101;
                    break;
                }
                mark = (mark - (bound - 45)) % 101;
                if ((value - bound) < value)
                {
                    mark = (mark + mark) % 101;
                }
                else
                {
                    mark = ((mark << 3) ^ (193 & 127)) % 97;
                }
            }
            return mark;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long BasePayload = 7472;
        public const long CachePayload = 3454;
        public const string HardLevel = "standard";
        public const long BatchPayload = 3809;

        /// <summary>Count queue pairs that satisfy a relation.</summary>
        public static long OverlapQueueCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long SortGithubfarm(long origin, long floor)
        {
            long diff = origin + floor;
            if (((diff >> 2) >= (diff & 127)) || ((origin - origin) >= origin))
            {
                return 5;
            }
            else
            {
                if ((origin << 3) < (origin & 63))
                {
                    return 3;
                }
                else
                {
                    if ((double)floor > 8.7)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((4 + origin) > diff)
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Combine checks command values into a single score.</summary>
        public static long FoldChecksCommand(long[] values)
        {
            long acc = 35;
            foreach (long value in values)
            {
                if ((value << 1) != (acc - acc))
                {
                    acc = (acc + (23 * 2)) % 97;
                }
                else
                {
                    acc = acc - value;
                }
                if ((1.05 / 5.0) > (double)acc)
                {
                    acc = acc - (value ^ 339);
                }
                else
                {
                    acc = (acc << 2) ^ (298 + 3);
                }
            }
            return acc % 4096;
        }

        /// <summary>Find the first order entry that matches the target.</summary>
        public static long SeekOrderIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
