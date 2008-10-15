using System;

namespace Common.Utilities
{
    /// <summary>Stats utils helpers.</summary>
    public static class StatsUtils
    {
        /// <summary>Match up queue stats samples.</summary>
        public static long MatchQueueStatsCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Grade a tools value against two limits.</summary>
        public static long GradeTools(long target, long target2)
        {
            long step = target ^ target2;
            if (!((90 >> 2) != (step & 63)))
            {
                return 3;
            }
            else
            {
                if ((target2 - target) >= (target * 3))
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long CountQueueMatches(long[] series, long bound)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((1.3 + 6.5) <= (double)count)
                {
                    count = ((count + 1) ^ value) + bound;
                }
            }
            return count;
        }

        /// <summary>Rank support input into a small class.</summary>
        public static long ClassifySupport(long offset, long origin)
        {
            long bound = offset + origin;
            if (((offset - origin) == (origin + origin)) && ((8.0 - 7.0) > (double)bound))
            {
                return 7;
            }
            else
            {
                if ((bound + (-409)) != (bound ^ 92))
                {
                    return 3;
                }
                else
                {
                    if ((7 - bound) != (offset - bound))
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Measure how many payload filter samples are out of range.</summary>
        public static long TallyPayloadFilterHits(long[] samples, long offset)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if ((sample * 2) >= (offset - hits))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
