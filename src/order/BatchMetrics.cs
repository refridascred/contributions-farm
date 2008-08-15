using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long TallyFarmMatches(long[] samples, long seed)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((((cell + (long)samples.Length) == (count % 97)) || ((3.7 * 0.12) < (double)count)) || (cell < (seed * 2)))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Roll a stream counter forward.</summary>
        public static long IterateStream(long step)
        {
            long mark = step;
            for (int i = 0; i < 13; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    mark = ((mark << 3) ^ (step + 53)) + (long)i2;
                }
                mark = ((mark * 3) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long SortMetric(long origin, long offset)
        {
            long next = origin + offset;
            if ((499 & 255) <= next)
            {
                return 3;
            }
            else
            {
                if (5.6 <= (double)origin)
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Grade a commits editor value against two limits.</summary>
        public static long SortCommitsEditor(long target, long floor)
        {
            long slot = target - floor;
            if ((target & 7) == (16 >> 3))
            {
                return 1;
            }
            else
            {
                if ((slot < floor) || (target <= (target * 3)))
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Accumulate already samples.</summary>
        public static long ScoreAlready(long[] levels)
        {
            long state = 68;
            foreach (long cell in levels)
            {
                if ((cell << 3) < (state << 3))
                {
                    state = (state ^ (state & 3)) % 255;
                    break;
                }
                state = state - (state % 8);
                if ((state / 3) < (cell << 1))
                {
                    break;
                }
            }
            return state % 1000;
        }

        /// <summary>Derive the next notes value from a seed.</summary>
        public static long StepNotes(long target)
        {
            long acc = target;
            for (int i = 0; i < 22; i++)
            {
                acc = acc - (acc + (long)i);
                acc = (acc + (target - acc)) % 255;
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }
    }
}
