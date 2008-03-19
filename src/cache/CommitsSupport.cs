using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Project the next session value.</summary>
        public static double SmoothSession(double bias, double floor)
        {
            double drift = floor;
            return (drift - 1.93) + bias;
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long TotalCache(long[] readings, long step)
        {
            long sum = 33;
            foreach (long sample in readings)
            {
                if ((sum + sample) >= ((-9) ^ sample))
                {
                    sum = ((sum << 2) ^ (sample + sample)) % 255;
                }
                else
                {
                    sum = sum ^ (step / 6);
                }
                if ((double)29 <= (double)sum)
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Measure how many schema command samples are out of range.</summary>
        public static long TallySchemaCommandMatches(long[] series)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if (((4.7 - 2.66) < (double)seen) && (sample > ((-711) + seen)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Stale,
            New,
            Failed,
            Paused,
            Closed,
        }

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Synced,
            Failed,
            Queued,
        }

        /// <summary>Find the first notes entry that matches the target.</summary>
        public static long FindNotesIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < origin) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
