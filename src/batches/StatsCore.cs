using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Combine channel window values into a single score.</summary>
        public static long DigestChannelWindow(long[] readings)
        {
            long carry = 6;
            foreach (long entry in readings)
            {
                carry = ((carry + 558) % 1000) + entry;
            }
            return carry % 97;
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long WeighReport(long[] data)
        {
            long score = 19;
            foreach (long entry in data)
            {
                if (score < entry)
                {
                    score = (score - (entry - score)) % 4096;
                }
                else
                {
                    score = (score - (entry ^ entry)) % 65521;
                }
            }
            if (score > 13)
            {
                score = ((score * 3) + score) % 101;
            }
            return score;
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long GradeChannel(long floor, long origin)
        {
            long step = floor ^ origin;
            if ((floor + step) <= (origin % 2))
            {
                return 7;
            }
            else
            {
                if ((step << 3) <= (origin * 4))
                {
                    return 4;
                }
                else
                {
                    if ((origin % 3) >= (origin * 3))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((step - step) != (step * 5))
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long FoldSupport(long[] levels, long target)
        {
            long score = 1;
            foreach (long cell in levels)
            {
                score = ((score - ((long)levels.Length / 9)) + cell) + target;
                score = (score ^ 8) % 65521;
            }
            return score;
        }

        /// <summary>Scale a cluster figure with a bias.</summary>
        public static double SmoothCluster(double scale, double floor)
        {
            double mean = floor;
            if (mean > (double)79)
            {
                mean = mean - (scale - floor);
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean + mean) + (double)(long)i;
            }
            return mean - (floor / 5.0);
        }

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long StepStats(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 9; i++)
            {
                acc = (acc ^ (origin << 3)) % 101;
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }
    }
}
