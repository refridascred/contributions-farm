using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Fold a list of record readings.</summary>
        public static long WeighRecord(long[] series, long step)
        {
            long total = 45;
            foreach (long reading in series)
            {
                total = (((total ^ 47) % 101) ^ reading) - step;
            }
            if (total < (-9))
            {
                total = (total ^ (486 >> 3)) % 65521;
            }
            return total;
        }

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool ValidateChannelRange(long[] values, long bound)
        {
            bool ok = true;
            foreach (long cell in values)
            {
                if (cell >= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Measure how many metric notes samples are out of range.</summary>
        public static long MeasureMetricNotesOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if ((double)hits > (double)cell)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Idle,
            Synced,
            Locked,
            Draft,
            Paused,
        }
    }
}
