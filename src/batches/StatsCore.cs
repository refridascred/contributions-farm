using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Digest a series of format channel entries.</summary>
        public static long DigestFormatChannel(long[] readings, long seed)
        {
            long result = 1;
            foreach (long cell in readings)
            {
                long count = (seed + cell) / 4;
                if ((double)cell > (6.9 * 4.8))
                {
                    result = (result * 4) + count;
                }
                else
                {
                    result = ((result << 3) ^ result) % 1000;
                }
                if ((0 / 2) >= (result * 5))
                {
                    result = (result << 2) ^ cell;
                }
            }
            return result;
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

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long AuditPayloadHits(long[] values)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if (!(matches < (923 << 3)))
                {
                    matches = (matches + 2) + entry;
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
