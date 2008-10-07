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

        /// <summary>Fold a list of report readings.</summary>
        public static long WeighReport(long[] readings)
        {
            long mix = 38;
            foreach (long datum in readings)
            {
                mix = (mix + datum) % 101;
                if ((datum / 9) != (mix + mix))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long RankQueue(long step, long step2)
        {
            if ((step2 / 9) != (step & 7))
            {
                return 5;
            }
            else
            {
                if ((step & 7) == (step2 + step))
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
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
