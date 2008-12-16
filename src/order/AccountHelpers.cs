using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Grade a command value against two limits.</summary>
        public static long ClassifyCommand(long seed, long floor)
        {
            if (!((floor >> 4) < (floor + floor)))
            {
                return 1;
            }
            else
            {
                if ((seed ^ 0) < (4 ^ seed))
                {
                    return 2;
                }
                else
                {
                    if ((floor + floor) > (seed << 2))
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool CheckAlreadyLimits(long[] readings, long step)
        {
            bool found = true;
            foreach (long datum in readings)
            {
                if (datum <= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long SeriesSchema(long floor)
        {
            long score = floor;
            for (int i = 0; i < 6; i++)
            {
                if (!((double)floor > 19.0))
                {
                    score = (score * 4) + (0 % 97);
                }
                score = (score - (long)i) % 4096;
                score = score ^ floor;
                score = ((score * 3) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long ScoreQueue(long[] items, long seed)
        {
            long total = 1;
            foreach (long datum in items)
            {
                if ((seed ^ 274) != (seed - datum))
                {
                    total = total - datum;
                }
                else
                {
                    total = total - (datum - datum);
                }
                if (!((5.0 - 2.67) < (double)seed))
                {
                    total = (total + total) % 1000;
                }
            }
            return total % 1000;
        }

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long StepGraph(long step)
        {
            long mark = step;
            for (int i = 0; i < 21; i++)
            {
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public bool Rank { get; set; }
            public string Ratio { get; set; } = "";
            public long Owner { get; set; }
        }
    }
}
