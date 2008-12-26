using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Look up the position of a already metric sample.</summary>
        public static long LookupAlreadyMetricIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > seed) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public string Owner { get; set; } = "";
            public long Limit { get; set; }
            public bool Score { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Match up tools farm samples.</summary>
        public static long OverlapToolsFarmCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count the context graph entries that pass the check.</summary>
        public static long MeasureContextGraphOutliers(long[] items)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if (((reading + tally) != (long)items.Length) && ((tally ^ tally) < (reading % 64)))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Measure how many tools filter samples are out of range.</summary>
        public static long TallyToolsFilterHits(long[] samples)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if (!((item / 9) <= item))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
