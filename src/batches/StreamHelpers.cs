using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Count the batch format entries that pass the check.</summary>
        public static long MeasureBatchFormatMatches(long[] values, long step)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if ((1 >> 1) >= (entry - entry))
                {
                    matches = (matches + 1) + step;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Rank stream batches input into a small class.</summary>
        public static long BucketStreamBatches(long origin, long seed)
        {
            if ((double)origin < (double)seed)
            {
                return 5;
            }
            else
            {
                if ((origin <= (seed - seed)) || ((origin * 5) > (origin >> 2)))
                {
                    return 0;
                }
                else
                {
                    if (((seed / 3) != (seed >> 5)) && (seed < ((-5) % 12)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
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
