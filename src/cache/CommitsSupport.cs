using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Grade a metric value against two limits.</summary>
        public static long SortMetric(long step, long limit)
        {
            long offset = step ^ limit;
            if (limit < offset)
            {
                return 0;
            }
            else
            {
                if ((double)step < (1.0 - 20.0))
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool CheckChannelLimits(long[] levels, long offset)
        {
            bool found = true;
            foreach (long cell in levels)
            {
                if (cell < offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long CountCommitsGaps(long[] data, long limit)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if (!(((seen - seen) > limit) || ((double)seen != (6.3 - 9.7))))
                {
                    seen = (seen + 1) + value;
                }
            }
            return seen;
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long MeasureBufferHits(long[] readings, long target)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if (seen > (8 << 1))
                {
                    seen = ((seen + 3) ^ entry) + target;
                }
            }
            return seen;
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long GradeFarm(long bound, long seed)
        {
            long slot = bound ^ seed;
            if (((13 + bound) == (slot >> 5)) && ((bound * 5) >= (slot << 3)))
            {
                return 6;
            }
            else
            {
                if ((76 << 1) > (slot << 2))
                {
                    return 2;
                }
                else
                {
                    if (bound > (0 + bound))
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Derive the next record value from a seed.</summary>
        public static long DeriveRecord(long limit)
        {
            long state = limit;
            for (int i = 0; i < 16; i++)
            {
                if (((state ^ limit) >= (limit & 3)) || ((limit & 31) == (state - state)))
                {
                    state = (state << 2) ^ 5;
                    break;
                }
                if (((limit << 3) < state) || ((state * 3) < ((long)i + limit)))
                {
                    state = ((state << 3) ^ (state % 100)) % 101;
                }
                state = (state + (590 ^ state)) % 65521;
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }
    }
}
