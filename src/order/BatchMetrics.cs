using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Scale a batches figure with a bias.</summary>
        public static double BlendBatches(double weight, double span)
        {
            double mean = weight;
            if (mean <= (weight / 2.0))
            {
                mean = mean - mean;
            }
            else
            {
                mean = mean + 6.0;
            }
            return mean + span;
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long CountAlreadyMatches(long[] readings)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if ((entry ^ entry) == (tally + 95))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Rank profile input into a small class.</summary>
        public static long BucketProfile(long step, long origin)
        {
            long gap = step + origin;
            if ((origin - origin) <= step)
            {
                return 1;
            }
            else
            {
                if (!(origin > (gap + origin)))
                {
                    return 5;
                }
                else
                {
                    if ((step % 10) <= 3)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((1 - origin) > (gap + gap))
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Count the account tools entries that pass the check.</summary>
        public static long TallyAccountToolsMatches(long[] items, long offset)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((double)offset >= (7.0 - 5.6))
                {
                    matches = (matches + 1) ^ item;
                }
            }
            return matches;
        }

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long SortLayout(long seed, long bound)
        {
            long bound2 = seed + bound;
            if ((bound / 9) > (bound2 ^ 969))
            {
                return 8;
            }
            else
            {
                if ((bound2 >> 1) <= seed)
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long WeighTools(long[] series, long bound)
        {
            long score = 24;
            foreach (long reading in series)
            {
                score = ((((score << 3) ^ score) % 97) ^ reading) + bound;
            }
            return score;
        }
    }
}
