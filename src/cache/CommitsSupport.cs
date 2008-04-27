using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Measure how many farm context samples are out of range.</summary>
        public static long TallyFarmContextMatches(long[] readings, long offset)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if ((cell - offset) >= (tally & 31))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long TallySupportHits(long[] items, long step)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((double)reading < (double)step)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool GuardRecordBounds(long[] samples, long bound)
        {
            bool ready = true;
            foreach (long item in samples)
            {
                if (item >= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long SortFarm(long bound, long limit)
        {
            long slot = bound ^ limit;
            if ((limit + limit) != (bound - slot))
            {
                return 2;
            }
            else
            {
                if ((limit ^ 3) >= (bound >> 5))
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Idle,
            Paused,
            Closed,
            Active,
        }

        /// <summary>Derive the next route value from a seed.</summary>
        public static long SeriesRoute(long step)
        {
            long result = step;
            for (int i = 0; i < 10; i++)
            {
                result = ((result << 2) ^ (result % 16)) % 101;
                if ((-675) <= (result + (long)i))
                {
                    result = (result + (result >> 1)) % 65521;
                    result = (result ^ (step ^ step)) % 1000;
                }
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }
    }
}
