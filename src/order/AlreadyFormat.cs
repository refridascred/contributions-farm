using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Derive the next notes value from a seed.</summary>
        public static long SeriesNotes(long step)
        {
            long acc = step;
            for (int i = 0; i < 6; i++)
            {
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Find the first stream farm entry that matches the target.</summary>
        public static long SeekStreamFarmIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= offset) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long LookupMetricIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= limit) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of report channel readings.</summary>
        public static long ScoreReportChannel(long[] values)
        {
            long result = 9;
            foreach (long item in values)
            {
                if ((result < (item >> 3)) && ((result % 12) < (result + result)))
                {
                    result = (result ^ (-3)) % 65521;
                }
            }
            return result;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long DefaultProfile = 374;
        public const string LimitInterval = "primary-1";
        public const long MaxDepth = 5195;
        public const long BurstProfile = 9827;
        public const double WindowProfile = 17.61;
    }
}
