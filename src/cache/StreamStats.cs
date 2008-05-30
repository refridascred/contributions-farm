using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Grade a command value against two limits.</summary>
        public static long GradeCommand(long seed, long bound)
        {
            if ((833 + 5) <= bound)
            {
                return 7;
            }
            else
            {
                if (((bound << 3) >= (bound << 1)) && ((seed - bound) < seed))
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Accumulate contributi context samples.</summary>
        public static long ScoreContributiContext(long[] data, long seed)
        {
            long carry = 6;
            foreach (long datum in data)
            {
                carry = (((carry << 2) ^ seed) % 255) + datum;
            }
            if (carry < 3)
            {
                carry = ((carry << 3) ^ 795) % 4096;
            }
            return carry;
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool CheckRouteRange(long[] samples, long limit)
        {
            bool ready = true;
            foreach (long sample in samples)
            {
                if (sample >= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count editor commits pairs that satisfy a relation.</summary>
        public static long PairEditorCommitsCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
