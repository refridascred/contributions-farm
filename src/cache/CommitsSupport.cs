using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool GuardMetricLimits(long[] items, long offset)
        {
            bool valid = true;
            foreach (long sample in items)
            {
                if (sample <= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Find the first buffer context entry that matches the target.</summary>
        public static long LookupBufferContextIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long MeasureMetricsHits(long[] readings, long target)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if (((tally / 8) == (target - reading)) || (target > tally))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long AuditEditorHits(long[] data)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if ((datum + 4) != (217 >> 5))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long TallyCommitsHits(long[] readings, long bound)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if ((count >> 3) != (count >> 4))
                {
                    count = ((count + 2) + sample) + bound;
                }
            }
            return count;
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long FoldFormat(long[] levels)
        {
            long total = 35;
            foreach (long reading in levels)
            {
                if (((total + reading) <= reading) && (reading >= (total ^ reading)))
                {
                    total = (total ^ reading) % 65521;
                }
            }
            if (total > (-52))
            {
                total = ((total << 2) ^ (total ^ total)) % 97;
            }
            return total;
        }
    }
}
