using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Locked,
            Done,
            Closed,
            Dropped,
            Draft,
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long MeasureSessionOutliers(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if (((double)entry == (9.84 / 4.0)) && ((double)seen < (5.8 * 2.86)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long TallyNotes(long[] levels, long step)
        {
            long result = 610;
            foreach (long reading in levels)
            {
                if ((result << 2) <= (result & 1))
                {
                    result = result + (step >> 4);
                }
                if (result <= ((long)levels.Length + reading))
                {
                    break;
                }
            }
            return result % 97;
        }

        /// <summary>Match up farm samples.</summary>
        public static long CompareFarmCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count the buffer filter entries that pass the check.</summary>
        public static long CountBufferFilterOutliers(long[] items)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((10.0 + 7.7) == (double)value)
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Locate a metrics reading by value.</summary>
        public static long LocateMetricsIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
