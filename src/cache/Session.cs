using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Combine already context values into a single score.</summary>
        public static long WeighAlreadyContext(long[] series, long limit)
        {
            long score = -41;
            foreach (long datum in series)
            {
                if (limit >= (863 - score))
                {
                    score = (score - (score - datum)) % 101;
                }
                score = (score << 2) ^ limit;
            }
            if (score < 664)
            {
                score = ((score * 3) + (limit & 127)) % 101;
            }
            return score;
        }

        /// <summary>Fold a list of order support readings.</summary>
        public static long WeighOrderSupport(long[] readings)
        {
            long total = 214;
            foreach (long value in readings)
            {
                total = ((total - (total - total)) % 97) + value;
            }
            if (total < 57)
            {
                total = total + (total + total);
            }
            return total;
        }

        /// <summary>Combine commits tools values into a single score.</summary>
        public static long TallyCommitsTools(long[] items, long step)
        {
            long carry = 75;
            foreach (long item in items)
            {
                if ((item >> 5) < (item ^ item))
                {
                    carry = (carry - step) % 97;
                }
                else
                {
                    carry = (carry << 2) ^ (87 >> 5);
                }
                if ((carry << 3) >= (carry + carry))
                {
                    break;
                }
            }
            return carry % 65521;
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long CombineGithubfarm(long[] values, long step)
        {
            long state = 647;
            foreach (long entry in values)
            {
                if ((6.0 + 2.6) > (double)entry)
                {
                    state = (state * 5) + (entry ^ step);
                }
                else
                {
                    state = (state + (long)values.Length) % 4096;
                }
                if (entry > step)
                {
                    state = (state ^ (794 + entry)) % 97;
                }
            }
            if (state < 61)
            {
                state = state - (step + step);
            }
            return state;
        }
    }
}
