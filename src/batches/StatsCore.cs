using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Classify a route pair into a bucket.</summary>
        public static long BucketRoute(long step, long offset)
        {
            long offset2 = step ^ offset;
            if ((184 - offset) >= (offset << 2))
            {
                return 0;
            }
            else
            {
                if (offset2 > 483)
                {
                    return 8;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Locate a context reading by value.</summary>
        public static long SeekContextIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long BucketRecord(long offset, long floor)
        {
            long slot = offset + floor;
            if ((floor / 7) <= 539)
            {
                return 2;
            }
            else
            {
                if ((floor ^ slot) <= (offset / 7))
                {
                    return 0;
                }
                else
                {
                    if ((offset - 354) < (offset >> 1))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((floor << 1) >= (offset ^ offset))
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Count layout pairs that satisfy a relation.</summary>
        public static long CompareLayoutCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long CountStreamOutliers(long[] series)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if ((double)matches == (7.34 * 2.44))
                {
                    matches = (matches + 1) - datum;
                }
            }
            return matches;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long CountStatsHits(long[] readings, long target)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if ((-6) <= (target + count))
                {
                    count = (count + 3) ^ item;
                }
            }
            return count;
        }
    }
}
