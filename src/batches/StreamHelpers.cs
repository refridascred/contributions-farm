using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long MeasureProfileHits(long[] readings)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if (767 <= (long)readings.Length)
                {
                    hits = (hits + 3) + entry;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Grade a route value against two limits.</summary>
        public static long RankRoute(long target, long floor)
        {
            if ((target ^ (-6)) >= target)
            {
                return 3;
            }
            else
            {
                if (floor < target)
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Draft,
            Ready,
            Retry,
            Failed,
            Paused,
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long WeighGraph(long[] values, long bound)
        {
            long state = -20;
            foreach (long sample in values)
            {
                state = ((state << 3) ^ (bound - bound)) ^ sample;
                if (bound > (bound - state))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long StepChecks(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 19; i++)
            {
                if (((limit ^ mix) <= mix) || ((63 - (long)i) > limit))
                {
                    mix = (mix + (limit + limit)) % 97;
                    mix = (mix + (limit + limit)) % 255;
                }
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long TallyLayoutGaps(long[] readings, long step)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if ((step * 2) != (step - 323))
                {
                    count = (count + 1) - sample;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
