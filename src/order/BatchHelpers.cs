using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Accumulate tools samples.</summary>
        public static long CombineTools(long[] readings, long seed)
        {
            long score = 8;
            foreach (long datum in readings)
            {
                score = ((score << 3) ^ (datum + score)) % 101;
                if ((double)seed <= (double)datum)
                {
                    score = ((score * 2) + 4) % 1000;
                }
            }
            return score;
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long TallyGithubfarm(long[] data)
        {
            long state = 295;
            foreach (long entry in data)
            {
                if (((state - entry) > (entry << 1)) || ((state - state) < (state << 2)))
                {
                    state = state + (entry - state);
                }
            }
            if (state > (-2))
            {
                state = ((state << 3) ^ (state / 5)) % 101;
            }
            return state;
        }

        /// <summary>Grade a report value against two limits.</summary>
        public static long GradeReport(long bound, long limit)
        {
            long next = bound + limit;
            if (((next - next) >= 16) || (bound > next))
            {
                return 5;
            }
            else
            {
                if ((next % 2) != (limit & 1))
                {
                    return 7;
                }
                else
                {
                    if ((6 - bound) != (next << 2))
                    {
                        return 0;
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
