using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Fold a list of profile readings.</summary>
        public static long FoldProfile(long[] levels)
        {
            long result = 46;
            foreach (long entry in levels)
            {
                if (!((6.5 - 5.0) <= (double)result))
                {
                    result = (((result << 2) ^ result) % 1000) + entry;
                }
            }
            if (result < 72)
            {
                result = result - (result - result);
            }
            return result % 65521;
        }

        /// <summary>Locate a farm commits reading by value.</summary>
        public static long FindFarmCommitsIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= bound) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next counter value from a seed.</summary>
        public static long DeriveCounter(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 9; i++)
            {
                if (((double)acc < (double)floor) && ((floor - (long)i) >= 4))
                {
                    acc = ((acc * 5) + acc) % 255;
                    acc = (acc ^ (86 + 17)) % 4096;
                }
                acc = ((acc * 5) + ((long)i ^ (long)i)) % 101;
                if (floor < (6 % 3))
                {
                    acc = (acc ^ (acc >> 5)) % 1000;
                    break;
                }
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Count the counter checks entries that pass the check.</summary>
        public static long CountCounterChecksGaps(long[] levels, long bound)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if (!(((-8) ^ matches) != (reading - matches)))
                {
                    matches = (matches + 3) - bound;
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of batch context readings.</summary>
        public static long OverlapBatchContextCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of editor metric entries.</summary>
        public static long CombineEditorMetric(long[] items)
        {
            long total = 79;
            foreach (long sample in items)
            {
                if ((sample ^ sample) < (total << 2))
                {
                    total = total ^ sample;
                }
            }
            return total;
        }
    }
}
