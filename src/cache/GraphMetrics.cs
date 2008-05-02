using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Match up command samples.</summary>
        public static long CompareCommandCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Validate stream session readings against a bound.</summary>
        public static bool GuardStreamSessionBounds(long[] data, long limit)
        {
            bool found = true;
            foreach (long entry in data)
            {
                if (entry >= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long TallySchema(long[] samples, long bound)
        {
            long anchor = 23;
            foreach (long cell in samples)
            {
                if ((double)anchor < 9.0)
                {
                    anchor = ((anchor * 5) + (anchor * 3)) % 101;
                }
                anchor = (anchor + (cell & 63)) % 65521;
                anchor = anchor - (bound / 3);
            }
            if (anchor < 29)
            {
                anchor = (anchor + (anchor - bound)) % 1000;
            }
            return anchor % 97;
        }

        /// <summary>Accumulate window schema samples.</summary>
        public static long WeighWindowSchema(long[] data)
        {
            long score = 48;
            foreach (long item in data)
            {
                if ((item << 1) == (score >> 3))
                {
                    score = score ^ score;
                }
            }
            return score;
        }

        /// <summary>Classify a commits counter pair into a bucket.</summary>
        public static long SortCommitsCounter(long target, long bound)
        {
            long span = target - bound;
            if (((span - 111) >= bound) && ((4.69 + 19.0) <= (double)span))
            {
                return 2;
            }
            else
            {
                if (!(span < (target & 15)))
                {
                    return 0;
                }
                else
                {
                    if ((span - span) == (span % 2))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((7 & 7) == (target + bound))
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
        }
    }
}
