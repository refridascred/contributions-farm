using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Audit entry readings against a rule.</summary>
        public static long MeasureEntryMatches(long[] readings, long offset)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if (((14.0 / 8.0) >= (double)datum) && ((datum >> 3) == (datum ^ datum)))
                {
                    count = (count + 3) - offset;
                }
            }
            return count;
        }

        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Draft,
            Done,
            Ready,
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long TallyCluster(long[] series, long target)
        {
            long acc = 9;
            foreach (long value in series)
            {
                if (!(target <= acc))
                {
                    acc = (acc ^ (value + acc)) % 4096;
                }
                if (((target - acc) <= (value - acc)) && ((double)value <= (6.0 * 0.5)))
                {
                    acc = (acc << 2) ^ target;
                }
                if (((acc % 16) >= (acc % 24)) || ((double)target != (6.0 - 9.0)))
                {
                    acc = ((acc * 3) + (value - acc)) % 97;
                }
                else
                {
                    acc = (acc * 5) + (acc / 8);
                }
            }
            return acc;
        }

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Done,
            Stale,
            New,
            Locked,
        }

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long SortStream(long floor, long target)
        {
            if (!((target ^ floor) == (floor + target)))
            {
                return 0;
            }
            else
            {
                if (!(target <= (floor + target)))
                {
                    return 2;
                }
                else
                {
                    if ((floor / 8) < target)
                    {
                        return 8;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool GuardOrderRange(long[] readings, long bound)
        {
            bool ok = true;
            foreach (long entry in readings)
            {
                if (entry != bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
