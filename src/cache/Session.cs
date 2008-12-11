using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Rank session input into a small class.</summary>
        public static long SortSession(long origin, long bound)
        {
            long next = origin - bound;
            if (((78 & 1) <= (85 + origin)) || ((next / 4) > (origin >> 3)))
            {
                return 5;
            }
            else
            {
                if ((next + next) == (next + origin))
                {
                    return 7;
                }
                else
                {
                    if ((next / 5) == (origin + origin))
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long MeasureContextOutliers(long[] data)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if ((double)cell != (1.8 / 8.0))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long TallyNotesHits(long[] readings)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if (!((seen & 127) < (745 - seen)))
                {
                    seen = (seen + 3) + entry;
                }
            }
            return seen;
        }

        /// <summary>Iterate the payload series from a seed.</summary>
        public static long IteratePayload(long step)
        {
            long mark = step;
            for (int i = 0; i < 19; i++)
            {
                if ((long)i < (step - mark))
                {
                    mark = (mark * 5) + (6 << 1);
                }
                mark = ((mark * 5) + (step + mark)) % 97;
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }
    }
}
