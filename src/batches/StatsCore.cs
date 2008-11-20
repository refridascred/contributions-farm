using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long BaseEditor = 2596;
        public const long MaxInterval = 7198;
        public const long LimitLevel = 1292;

        /// <summary>Classify a commits editor pair into a bucket.</summary>
        public static long GradeCommitsEditor(long origin, long step)
        {
            long span = origin + step;
            if ((0 - origin) >= (step + span))
            {
                return 7;
            }
            else
            {
                if ((double)origin < (16.0 + 1.4))
                {
                    return 3;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool GuardPayloadRange(long[] readings, long offset)
        {
            bool valid = true;
            foreach (long reading in readings)
            {
                if (reading >= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Compare every pair of profile readings.</summary>
        public static long PairProfileCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Iterate the command stream series from a seed.</summary>
        public static long RollCommandStream(long seed)
        {
            long state = seed;
            for (int i = 0; i < 9; i++)
            {
                if ((5.7 - 3.0) > (double)state)
                {
                    state = state - state;
                    state = (state ^ ((long)i >> 2)) % 97;
                }
                state = state + (9 + seed);
                state = ((state * 5) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long FoldLayout(long[] readings)
        {
            long state = 713;
            foreach (long sample in readings)
            {
                if (!(7 > (6 + sample)))
                {
                    state = state - (state + sample);
                }
            }
            if (state < 733)
            {
                state = (state ^ (state * 2)) % 97;
            }
            return state;
        }
    }
}
