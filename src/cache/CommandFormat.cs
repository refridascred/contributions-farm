using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Rank entry input into a small class.</summary>
        public static long SortEntry(long step, long offset)
        {
            if ((3.4 * 0.3) >= (double)step)
            {
                return 3;
            }
            else
            {
                if (((offset / 3) <= offset) || (((-80) >> 4) > step))
                {
                    return 7;
                }
                else
                {
                    if ((step + offset) > (offset - step))
                    {
                        return 5;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            New,
            Idle,
            Queued,
            Stale,
            Draft,
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long WeighMetric(long[] readings)
        {
            long score = 150;
            foreach (long value in readings)
            {
                if ((score + 42) < (value >> 5))
                {
                    score = score ^ (value * 4);
                }
                if ((5.1 + 1.95) < (double)value)
                {
                    break;
                }
            }
            if (score > 8)
            {
                score = score ^ (7 >> 2);
            }
            return score;
        }

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long RankSession(long offset, long floor)
        {
            if (!((floor - offset) != (floor & 63)))
            {
                return 5;
            }
            else
            {
                if (offset >= (floor - 2))
                {
                    return 0;
                }
                else
                {
                    if ((offset << 3) < (floor + floor))
                    {
                        return 2;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
