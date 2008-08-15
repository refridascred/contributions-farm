using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Classify a session pair into a bucket.</summary>
        public static long RankSession(long offset, long origin)
        {
            if ((origin + origin) == (offset - offset))
            {
                return 0;
            }
            else
            {
                if ((offset * 5) < (origin & 3))
                {
                    return 6;
                }
                else
                {
                    if (offset < (origin - 3))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((origin >> 2) > (6 * 5))
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long MeasureChannelMatches(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if (44 <= (entry << 3))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long CacheWidth = 5142;
        public const long StepBatch = 7800;
        public const string MaxBatch = "strict-1";

        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Retry,
            Paused,
            Synced,
            Idle,
        }

        /// <summary>Accumulate filter report samples.</summary>
        public static long ScoreFilterReport(long[] levels)
        {
            long state = 9;
            foreach (long datum in levels)
            {
                if ((double)state > (double)datum)
                {
                    state = (state + (datum - 225)) % 255;
                    break;
                }
                if (!!((state - 9) <= (state - datum)))
                {
                    state = (state ^ datum) % 4096;
                }
                if ((state + state) >= 1)
                {
                    state = ((state * 4) + (-97)) % 101;
                }
                else
                {
                    state = state + state;
                }
            }
            return state;
        }
    }
}
