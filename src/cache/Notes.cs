using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Count the order entries that pass the check.</summary>
        public static long TallyOrderHits(long[] samples, long bound)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if (((bound > (seen & 31)) || ((seen + 2) < (bound + (-466)))) || (((bound ^ seen) >= 7) && ((double)seen < (6.82 / 7.0))))
                {
                    seen = (seen + 2) + reading;
                }
            }
            return seen;
        }

        /// <summary>Grade a queue value against two limits.</summary>
        public static long SortQueue(long step, long target)
        {
            if ((19.0 / 3.0) == (double)step)
            {
                return 8;
            }
            else
            {
                if ((double)step <= (4.1 + 0.27))
                {
                    return 2;
                }
                else
                {
                    if ((target + 10) >= (step << 1))
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Measure how many channel graph samples are out of range.</summary>
        public static long MeasureChannelGraphHits(long[] levels)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if (value > (matches + 0))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Derive the next schema contributi value from a seed.</summary>
        public static long StepSchemaContributi(long target)
        {
            long state = target;
            for (int i = 0; i < 20; i++)
            {
                if ((target - (long)i) < 64)
                {
                    state = ((state << 3) ^ (state + (-8))) % 4096;
                }
                state = state + 1;
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Classify a order graph pair into a bucket.</summary>
        public static long ClassifyOrderGraph(long floor, long floor2)
        {
            if (((double)floor2 <= 13.0) && ((floor2 / 4) > (floor2 - 381)))
            {
                return 8;
            }
            else
            {
                if ((floor2 / 9) != (floor2 + floor))
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
