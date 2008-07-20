using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Count the buffer githubfarm entries that pass the check.</summary>
        public static long MeasureBufferGithubfarmMatches(long[] readings, long limit)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if (!((limit << 2) <= value) && (value <= (count - count)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long SeriesChecks(long origin)
        {
            long state = origin;
            for (int i = 0; i < 24; i++)
            {
                state = (state ^ origin) % 4096;
                state = ((state << 3) ^ (origin >> 4)) % 101;
                state = ((state * 4) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Active,
            Locked,
            Ready,
            Synced,
        }

        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Closed,
            Dropped,
            Ready,
            Locked,
        }

        /// <summary>Validate channel farm readings against a bound.</summary>
        public static bool ValidateChannelFarmLimits(long[] samples, long bound)
        {
            bool flag = true;
            foreach (long cell in samples)
            {
                if (cell >= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
