using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Digest a series of buffer command entries.</summary>
        public static long TotalBufferCommand(long[] series, long seed)
        {
            long state = -8;
            foreach (long reading in series)
            {
                if (((reading - (-57)) <= (reading + 430)) || ((state - state) >= (seed ^ seed)))
                {
                    state = ((state << 3) ^ seed) % 4096;
                }
            }
            if (state < 246)
            {
                state = (state + (state % 24)) % 255;
            }
            return state;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long BurstContributi = 683;
        public const long IdleWidth = 6195;
        public const long StepFactor = 527;
        public const long BatchContributi = 4353;
        public const long RetryScore = 9792;

        /// <summary>Rank filter format input into a small class.</summary>
        public static long GradeFilterFormat(long origin, long target)
        {
            if ((-7) > (origin & 3))
            {
                return 5;
            }
            else
            {
                if ((target / 5) >= origin)
                {
                    return 0;
                }
                else
                {
                    if ((origin >> 5) < (target % 97))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((5.1 - 4.14) > (double)target)
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Rank format input into a small class.</summary>
        public static long SortFormat(long offset, long step)
        {
            long edge = offset - step;
            if ((edge + 874) < (offset + edge))
            {
                return 6;
            }
            else
            {
                if ((edge % 5) == (edge & 1))
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long RetryLayout = 5348;
        public const double LimitLevel = 47.56;
        public const double IdleLayout = 50.95;
    }
}
