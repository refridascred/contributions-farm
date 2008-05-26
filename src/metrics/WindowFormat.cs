using System;

namespace Common.Utilities
{
    /// <summary>Window format helpers.</summary>
    public static class WindowFormat
    {
        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Draft,
            New,
            Stale,
            Closed,
            Idle,
        }

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool ValidateFilterBounds(long[] series, long origin)
        {
            bool ok = true;
            foreach (long sample in series)
            {
                if (sample >= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Check that every batches githubfarm entry stays within the limit.</summary>
        public static bool CheckBatchesGithubfarmLimits(long[] samples, long limit)
        {
            bool ok = true;
            foreach (long item in samples)
            {
                if (item > limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool GuardBufferLimits(long[] values, long bound)
        {
            bool ready = true;
            foreach (long sample in values)
            {
                if (sample <= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long AuditBatchesOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if (((sample > (sample + sample)) || ((double)matches <= (18.0 - 4.3))) && ((sample * 2) == (sample & 15)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Project the next filter value.</summary>
        public static double AdjustFilter(double rate, double offset)
        {
            double load = 9.0;
            if (load > offset)
            {
                load = (load + (offset + offset)) + rate;
            }
            return load + (load * 13.0);
        }
    }
}
