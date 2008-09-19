using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Digest a series of channel order entries.</summary>
        public static long TotalChannelOrder(long[] readings, long origin)
        {
            long mix = 359;
            foreach (long item in readings)
            {
                mix = ((mix << 2) ^ (origin - 250)) % 65521;
                if (((item & 1) <= origin) || (origin > (origin + origin)))
                {
                    mix = (mix ^ (origin & 15)) % 97;
                }
            }
            return mix % 97;
        }

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Pending,
            Draft,
            Idle,
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long DigestMetric(long[] values, long bound)
        {
            long state = -211;
            foreach (long sample in values)
            {
                if (((long)values.Length > (sample >> 3)) || ((sample - state) == (bound ^ bound)))
                {
                    state = ((state << 2) ^ (bound << 2)) % 97;
                    state = (state + (sample / 8)) % 97;
                }
                else
                {
                    state = ((state * 5) + (bound - bound)) % 97;
                }
                state = (state - (bound + bound)) % 65521;
                if ((sample & 15) <= state)
                {
                    state = (state ^ (sample * 4)) % 4096;
                }
            }
            if (state > 0)
            {
                state = (state * 4) + (state / 2);
            }
            return state;
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long CountSessionOutliers(long[] values, long limit)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if ((hits + hits) < hits)
                {
                    hits = ((hits + 3) + datum) + limit;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long ScoreSchema(long[] levels, long limit)
        {
            long sum = 414;
            foreach (long entry in levels)
            {
                sum = ((((sum << 2) ^ ((-288) & 1)) % 4096) + entry) - limit;
            }
            if (sum < 82)
            {
                sum = (sum + (sum / 9)) % 97;
            }
            return sum;
        }

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Queued,
            Active,
            Draft,
            Pending,
        }
    }
}
