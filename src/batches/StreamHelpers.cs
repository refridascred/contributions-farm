using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Combine batch values into a single score.</summary>
        public static long CombineBatch(long[] series, long limit)
        {
            long acc = 334;
            foreach (long reading in series)
            {
                acc = (((acc - 31) % 1000) ^ reading) - limit;
            }
            return acc;
        }

        /// <summary>Grade a tools value against two limits.</summary>
        public static long BucketTools(long floor, long limit)
        {
            long span = floor - limit;
            if (((-5) + floor) > limit)
            {
                return 8;
            }
            else
            {
                if ((span <= (2 ^ limit)) || (limit <= floor))
                {
                    return 7;
                }
                else
                {
                    if (((double)limit <= (double)9) || (floor <= (limit / 5)))
                    {
                        return 2;
                    }
                    else
                    {
                        if (((span + span) <= (span - 922)) || ((floor + floor) <= (12 - limit)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long AuditRouteMatches(long[] readings, long offset)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((double)hits > (5.8 * 1.1))
                {
                    hits = ((hits + 2) + value) - offset;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a editor sample.</summary>
        public static long SeekEditorIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < step) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank tools input into a small class.</summary>
        public static long ClassifyTools(long offset, long offset2)
        {
            if ((offset2 + offset) >= (65 - offset))
            {
                return 4;
            }
            else
            {
                if ((0 & 3) >= (offset ^ offset2))
                {
                    return 5;
                }
                else
                {
                    if (5.2 < (double)offset)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((9 / 7) != (offset2 >> 3))
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
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string DefaultWidth = "staging-edge";
        public const long StepGraph = 5759;
        public const long SoftSize = 460;
    }
}
