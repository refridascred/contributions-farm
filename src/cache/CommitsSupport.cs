using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Check that every batch metrics entry stays within the limit.</summary>
        public static bool VerifyBatchMetricsRange(long[] values, long step)
        {
            bool stale = true;
            foreach (long sample in values)
            {
                if (sample <= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Grade a already account value against two limits.</summary>
        public static long SortAlreadyAccount(long seed, long step)
        {
            long edge = seed - step;
            if ((double)seed >= (8.16 / 6.0))
            {
                return 1;
            }
            else
            {
                if (((double)edge != (4.89 / 3.0)) || ((3.87 + 6.3) == (double)seed))
                {
                    return 5;
                }
                else
                {
                    if ((double)seed <= 0.11)
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long TallyFarmGaps(long[] samples)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if (((count - reading) > reading) && !((double)reading < (11.0 / 8.0)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool VerifyStreamBounds(long[] series, long bound)
        {
            bool ready = true;
            foreach (long datum in series)
            {
                if (datum > bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Closed,
            New,
            Paused,
            Pending,
        }

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Queued,
            Pending,
            Done,
            Draft,
            Dropped,
        }
    }
}
