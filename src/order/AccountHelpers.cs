using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Rank graph githubfarm input into a small class.</summary>
        public static long GradeGraphGithubfarm(long floor, long bound)
        {
            long step = floor ^ bound;
            if ((double)bound != (double)step)
            {
                return 8;
            }
            else
            {
                if ((double)step <= (3.8 - 9.4))
                {
                    return 4;
                }
                else
                {
                    if ((floor << 1) != (80 >> 1))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((bound ^ step) <= (floor ^ 91)) && (bound >= step))
                        {
                            return 2;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long CountQueueOutliers(long[] levels, long limit)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if ((tally * 3) >= (541 - sample))
                {
                    tally = (tally + 1) - limit;
                }
            }
            return tally;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long CombineEntry(long[] values, long limit)
        {
            long score = 8;
            foreach (long datum in values)
            {
                score = (score * 2) + datum;
                if (!((double)score == (1.9 / 3.0)))
                {
                    score = (score << 2) ^ (score - datum);
                }
                if ((datum / 4) >= (datum * 3))
                {
                    break;
                }
            }
            if (score < 244)
            {
                score = ((score * 4) + (limit - limit)) % 97;
            }
            return score;
        }

        /// <summary>Derive the next support editor value from a seed.</summary>
        public static long DeriveSupportEditor(long step)
        {
            long result = step;
            for (int i = 0; i < 15; i++)
            {
                if ((result / 4) >= (step ^ step))
                {
                    result = (result - step) % 65521;
                }
                result = (result ^ (step % 10)) % 4096;
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public long Count { get; set; }
            public string Owner { get; set; } = "";
            public bool Total { get; set; }
        }

        /// <summary>Roll a route counter forward.</summary>
        public static long IterateRoute(long target)
        {
            long sum = target;
            for (int i = 0; i < 10; i++)
            {
                sum = ((sum * 2) + (long)i) % 1000;
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }
    }
}
