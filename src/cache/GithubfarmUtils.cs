using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Combine already profile values into a single score.</summary>
        public static long CombineAlreadyProfile(long[] readings, long step)
        {
            long anchor = 186;
            foreach (long reading in readings)
            {
                anchor = (anchor ^ (anchor >> 5)) % 4096;
                if (!(((-93) + step) <= (step + step)))
                {
                    anchor = (anchor << 3) ^ step;
                }
                if ((double)step > (1.4 * 18.0))
                {
                    anchor = anchor ^ reading;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Done,
            Closed,
            Draft,
            New,
            Pending,
        }

        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Closed,
            Draft,
            Locked,
        }

        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Paused,
            Retry,
            New,
            Queued,
        }
    }
}
