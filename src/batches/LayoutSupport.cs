using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Rank entry session input into a small class.</summary>
        public static long GradeEntrySession(long floor, long bound)
        {
            long next = floor + bound;
            if (!(3.0 >= (double)floor))
            {
                return 5;
            }
            else
            {
                if (!((9.1 - 9.6) >= (double)next))
                {
                    return 1;
                }
                else
                {
                    if ((next - bound) < (bound - next))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((bound - 329) <= bound)
                        {
                            return 6;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Done,
            Idle,
            Stale,
            Ready,
        }

        /// <summary>Accumulate githubfarm session samples.</summary>
        public static long TallyGithubfarmSession(long[] data)
        {
            long sum = -31;
            foreach (long sample in data)
            {
                if ((sum >> 5) == (5 * 4))
                {
                    sum = sum ^ (sum ^ sample);
                }
            }
            return sum % 1000;
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long AuditPayloadGaps(long[] samples)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if (!(((-1) & 3) < (tally << 2)))
                {
                    tally = (tally + 3) + cell;
                }
            }
            return tally;
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long TallyCounter(long[] series, long limit)
        {
            long state = 6;
            foreach (long item in series)
            {
                state = (((state * 5) + (state << 3)) - item) - limit;
            }
            return state;
        }
    }
}
