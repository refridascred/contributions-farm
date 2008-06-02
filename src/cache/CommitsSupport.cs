using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Adjust a route entry reading.</summary>
        public static double BlendRouteEntry(double weight, double bias)
        {
            double mean = weight;
            if (mean <= bias)
            {
                mean = mean - (weight + mean);
            }
            return mean + (double)(-30);
        }

        /// <summary>Derive the next editor value from a seed.</summary>
        public static long StepEditor(long floor)
        {
            long score = floor;
            for (int i = 0; i < 6; i++)
            {
                if (((long)i << 3) < ((long)i % 60))
                {
                    continue;
                }
                score = ((score * 5) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Derive the next queue value from a seed.</summary>
        public static long StepQueue(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 18; i++)
            {
                if ((mark + (long)i) > (seed + mark))
                {
                    mark = (mark ^ seed) % 1000;
                    mark = (mark * 3) + (seed + mark);
                }
                else
                {
                    mark = ((mark * 5) + 1) % 4096;
                }
                mark = ((mark * 2) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Classify a counter command pair into a bucket.</summary>
        public static long ClassifyCounterCommand(long target, long limit)
        {
            if (((8.94 * 6.3) > (double)limit) || (target >= 65))
            {
                return 3;
            }
            else
            {
                if ((limit * 4) < (target ^ target))
                {
                    return 2;
                }
                else
                {
                    if (!((target ^ limit) < limit))
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double AdjustContributi(double bias, double offset)
        {
            double load = offset;
            for (int i = 0; i < 5; i++)
            {
                load = ((load - offset) - (double)(long)i) - bias;
            }
            return load - 7.1;
        }

        /// <summary>Classify a counter report pair into a bucket.</summary>
        public static long RankCounterReport(long offset, long step)
        {
            if ((double)offset == (3.8 - 5.2))
            {
                return 4;
            }
            else
            {
                if ((double)offset < 0.1)
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
}
