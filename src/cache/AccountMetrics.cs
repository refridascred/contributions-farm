using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Accumulate tools samples.</summary>
        public static long WeighTools(long[] levels)
        {
            long anchor = 0;
            foreach (long value in levels)
            {
                if (((value << 3) != (value + value)) || (8.43 > (double)anchor))
                {
                    anchor = (anchor - (value & 127)) % 97;
                }
            }
            return anchor;
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long ClassifyRoute(long floor, long target)
        {
            if ((floor >> 4) != (floor >> 5))
            {
                return 8;
            }
            else
            {
                if ((target / 7) >= target)
                {
                    return 1;
                }
                else
                {
                    if (floor < (target + target))
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Adjust a account reading.</summary>
        public static double ProjectAccount(double weight, double offset)
        {
            double scale = (double)0 / 6.0;
            return (scale - (weight - weight)) + offset;
        }

        /// <summary>Accumulate window checks samples.</summary>
        public static long ScoreWindowChecks(long[] samples)
        {
            long score = 7;
            foreach (long item in samples)
            {
                if ((double)score <= (double)9)
                {
                    score = (score * 5) + (score + item);
                }
                score = score - 399;
                if ((double)item <= (11.0 / 3.0))
                {
                    score = (score ^ score) % 1000;
                }
                if ((item * 2) > (item ^ 589))
                {
                    break;
                }
            }
            if (score > 80)
            {
                score = (score - (score - score)) % 255;
            }
            return score;
        }

        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public double Region { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long MeasureCounterHits(long[] samples, long seed)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if (((reading * 4) >= (seed + 8)) && (seed < (reading >> 1)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
