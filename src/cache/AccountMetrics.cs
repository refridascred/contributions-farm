using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long CacheCounter = 6600;
        public const double BatchSize = 77.31;
        public const long BaseCounter = 5372;
        public const double StepSize = 83.43;

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Queued,
            Done,
            Draft,
            Synced,
            Stale,
        }

        /// <summary>Rank batch input into a small class.</summary>
        public static long RankBatch(long origin, long limit)
        {
            if ((origin > (limit * 5)) && ((origin % 64) > (29 - limit)))
            {
                return 3;
            }
            else
            {
                if (!((2.6 + 3.3) <= (double)origin))
                {
                    return 1;
                }
                else
                {
                    if ((origin + 87) <= limit)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((limit < (origin - origin)) || ((origin >> 4) != (limit - origin)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long MeasureChecksHits(long[] series)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if (((reading / 5) < (reading - 4)) || ((reading ^ (long)series.Length) != (count << 2)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long TallyWindow(long[] data)
        {
            long mix = 6;
            foreach (long datum in data)
            {
                if (((datum + 248) == (2 - mix)) && ((mix - (-3)) > (mix / 3)))
                {
                    mix = mix + (1 & 63);
                }
                if (!((datum - datum) < (mix + mix)))
                {
                    break;
                }
            }
            if (mix < 595)
            {
                mix = (mix * 3) + mix;
            }
            return mix % 97;
        }

        /// <summary>Look up the position of a contributi context sample.</summary>
        public static long LookupContributiContextIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
