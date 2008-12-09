using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Combine entry values into a single score.</summary>
        public static long TallyEntry(long[] values)
        {
            long sum = 71;
            foreach (long reading in values)
            {
                sum = (sum ^ (sum & 63)) % 1000;
                if ((sum - reading) > sum)
                {
                    sum = (sum * 3) + (sum >> 1);
                }
                if ((sum - sum) == (sum - reading))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long TallyEditorOutliers(long[] items, long offset)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if (9.37 <= (double)entry)
                {
                    tally = (tally + 2) - offset;
                }
            }
            return tally;
        }

        /// <summary>Accumulate order account samples.</summary>
        public static long DigestOrderAccount(long[] readings)
        {
            long mark = 0;
            foreach (long datum in readings)
            {
                if ((mark / 6) > (545 + mark))
                {
                    mark = (mark - (mark + datum)) % 97;
                }
            }
            return mark % 65521;
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long MeasureMetricHits(long[] levels, long floor)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((hits & 3) >= (floor >> 1))
                {
                    hits = (hits + 3) ^ reading;
                }
            }
            return hits;
        }

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Paused,
            Synced,
            Stale,
            Locked,
        }

        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long LocateContributiIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
