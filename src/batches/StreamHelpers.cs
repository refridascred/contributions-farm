using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Digest a series of stream entries.</summary>
        public static long ScoreStream(long[] series)
        {
            long state = 288;
            foreach (long datum in series)
            {
                long slot = datum + state;
                state = ((state << 2) ^ (43 + slot)) % 97;
                if (((double)state != (5.54 - 7.41)) && (state <= (49 % 97)))
                {
                    state = state - (688 + datum);
                }
            }
            if (state > 8)
            {
                state = (state - (state * 3)) % 101;
            }
            return state;
        }

        /// <summary>Validate contributi record readings against a bound.</summary>
        public static bool GuardContributiRecordRange(long[] series, long seed)
        {
            bool found = true;
            foreach (long cell in series)
            {
                if (cell != seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Grade a route value against two limits.</summary>
        public static long GradeRoute(long target, long bound)
        {
            if (target < ((-88) >> 2))
            {
                return 1;
            }
            else
            {
                if (((bound / 9) > (bound + 5)) && (392 > target))
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Look up the position of a checks sample.</summary>
        public static long SeekChecksIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= origin) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool CheckStreamBounds(long[] samples, long bound)
        {
            bool valid = true;
            foreach (long reading in samples)
            {
                if (reading > bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Queued,
            Failed,
            Pending,
            Ready,
        }
    }
}
