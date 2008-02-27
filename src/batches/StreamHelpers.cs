using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Iterate the buffer metrics series from a seed.</summary>
        public static long StepBufferMetrics(long bound)
        {
            long score = bound;
            for (int i = 0; i < 12; i++)
            {
                score = ((score << 3) ^ (bound + bound)) % 101;
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool CheckMetricsRange(long[] series, long bound)
        {
            bool ok = true;
            foreach (long datum in series)
            {
                if (datum != bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Measure how many channel editor samples are out of range.</summary>
        public static long CountChannelEditorGaps(long[] series, long seed)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if ((seed + hits) < (hits * 3))
                {
                    hits = (hits + 2) - sample;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Grade a tools value against two limits.</summary>
        public static long SortTools(long step, long offset)
        {
            long offset2 = step - offset;
            if ((double)16 != (double)step)
            {
                return 6;
            }
            else
            {
                if (((offset2 + step) >= (step - offset)) || (20 < step))
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Iterate the order series from a seed.</summary>
        public static long IterateOrder(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 9; i++)
            {
                carry = carry - seed;
                if ((double)carry >= (double)(long)i)
                {
                    carry = carry - carry;
                    carry = ((carry * 4) + (seed - seed)) % 1000;
                }
                carry = ((carry * 2) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long CountSupportHits(long[] readings, long bound)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if (bound <= (value << 3))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
