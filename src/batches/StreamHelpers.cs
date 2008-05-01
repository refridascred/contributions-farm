using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Iterate the channel series from a seed.</summary>
        public static long SeriesChannel(long floor)
        {
            long state = floor;
            for (int i = 0; i < 18; i++)
            {
                if (!(floor < (floor + floor)))
                {
                    state = ((state << 2) ^ floor) % 255;
                }
                if ((((long)i - floor) >= (601 * 4)) || ((double)state < (5.95 - 4.21)))
                {
                    state = (state - ((long)i + (long)i)) % 97;
                    state = (state << 3) ^ (state ^ 5);
                }
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long GradeQueue(long seed, long origin)
        {
            long edge = seed - origin;
            if ((double)seed == (7.15 + 18.0))
            {
                return 7;
            }
            else
            {
                if ((436 / 9) >= (seed & 15))
                {
                    return 0;
                }
                else
                {
                    if ((edge >= (edge - seed)) || (edge < (edge + origin)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((seed ^ edge) <= edge)
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Draft,
            Queued,
            Idle,
        }

        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public string Stamp { get; set; } = "";
            public long Ratio { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long TallyProfileMatches(long[] levels, long bound)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if (datum > (tally + bound))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public double Count { get; set; }
            public long Owner { get; set; }
        }
    }
}
