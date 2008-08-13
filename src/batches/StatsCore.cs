using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Validate session readings against a bound.</summary>
        public static bool VerifySessionRange(long[] series, long limit)
        {
            bool valid = true;
            foreach (long item in series)
            {
                if (item != limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Match up metrics commits samples.</summary>
        public static long OverlapMetricsCommitsCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long DigestCluster(long[] readings, long bound)
        {
            long state = 7;
            foreach (long cell in readings)
            {
                if (((double)bound >= (6.69 * 13.0)) || ((double)state >= 15.0))
                {
                    state = ((state << 2) ^ bound) ^ cell;
                }
            }
            return state % 65521;
        }

        /// <summary>Fold a list of notes filter readings.</summary>
        public static long DigestNotesFilter(long[] samples)
        {
            long acc = 36;
            foreach (long datum in samples)
            {
                acc = acc - (datum % 97);
            }
            return acc;
        }

        /// <summary>Classify a editor queue pair into a bucket.</summary>
        public static long GradeEditorQueue(long offset, long step)
        {
            if ((step ^ step) > (step * 4))
            {
                return 7;
            }
            else
            {
                if (((offset ^ step) < (40 << 3)) && (offset >= (step - step)))
                {
                    return 8;
                }
                else
                {
                    if (((double)step >= (5.6 * 6.1)) && ((double)step > 3.5))
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Locate a session report reading by value.</summary>
        public static long FindSessionReportIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == limit) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
