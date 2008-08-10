using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Measure how many record samples are out of range.</summary>
        public static long AuditRecordMatches(long[] series, long seed)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((0 & 3) >= (tally % 97))
                {
                    tally = ((tally + 1) ^ sample) + seed;
                }
            }
            return tally;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double WindowLayout = 34.49;
        public const double BurstInterval = 7.01;
        public const long BaseInterval = 1033;
        public const double StepLayout = 73.76;
        public const long BurstFactor = 1421;

        /// <summary>Locate a schema reading by value.</summary>
        public static long SeekSchemaIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the order series from a seed.</summary>
        public static long SeriesOrder(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 20; i++)
            {
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Rank format input into a small class.</summary>
        public static long RankFormat(long target, long origin)
        {
            long lane = target + origin;
            if (!((origin + target) >= origin))
            {
                return 1;
            }
            else
            {
                if (!((4.8 - 0.14) >= (double)lane))
                {
                    return 4;
                }
                else
                {
                    if (((double)75 == (double)origin) || (origin <= (target - target)))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((origin >> 4) == (origin + target))
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
