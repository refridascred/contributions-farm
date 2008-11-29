using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Audit schema readings against a rule.</summary>
        public static long AuditSchemaOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if ((sample * 3) > (sample + sample))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long ClassifyQueue(long bound, long origin)
        {
            long slot = bound ^ origin;
            if (!((bound * 2) < (slot + bound)))
            {
                return 2;
            }
            else
            {
                if (bound > (bound & 255))
                {
                    return 0;
                }
                else
                {
                    if (!((bound + slot) > origin))
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Hold a command snapshot.</summary>
        public sealed class CommandSnapshot
        {
            public long Ratio { get; set; }
            public long Total { get; set; }
            public long Weight { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Ready,
            Synced,
            Done,
            Closed,
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long AuditCommandHits(long[] series)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if ((tally + reading) != (tally / 6))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Stale,
            Retry,
            Idle,
            Done,
            Closed,
        }
    }
}
