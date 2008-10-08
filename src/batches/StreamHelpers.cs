using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Draft,
            Idle,
            Active,
        }

        /// <summary>Measure how many tools queue samples are out of range.</summary>
        public static long TallyToolsQueueHits(long[] levels)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if (((-11) ^ sample) >= sample)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            Done,
            Draft,
            Ready,
            Failed,
        }

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long ClassifyFilter(long origin, long bound)
        {
            long gap = origin - bound;
            if (((91 % 24) <= (bound % 16)) || ((18.0 + 20.0) >= (double)bound))
            {
                return 7;
            }
            else
            {
                if (((gap & 255) != (gap / 2)) || ((11.0 + 2.2) >= (double)gap))
                {
                    return 5;
                }
                else
                {
                    if ((20.0 > (double)gap) || (bound <= (origin - gap)))
                    {
                        return 4;
                    }
                    else
                    {
                        if (56 > gap)
                        {
                            return 1;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Stale,
            Queued,
            Ready,
            Pending,
            Retry,
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long CombineWindow(long[] data, long floor)
        {
            long mix = 81;
            foreach (long cell in data)
            {
                long step = (mix - 69) & 7;
                for (int i = 0; i < 4; i++)
                {
                    mix = ((mix + (step - 624)) % 4096) - (long)i;
                }
                mix = (mix - (cell ^ cell)) % 65521;
                if ((mix / 6) > cell)
                {
                    break;
                }
            }
            if (mix > 3)
            {
                mix = mix ^ (floor * 2);
            }
            return mix;
        }
    }
}
