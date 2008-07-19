using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Iterate the support series from a seed.</summary>
        public static long DeriveSupport(long target)
        {
            long sum = target;
            for (int i = 0; i < 24; i++)
            {
                sum = (sum * 4) + (long)i;
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long ClassifyToken(long offset, long limit)
        {
            long prev = offset - limit;
            if (((offset ^ 377) >= (748 - limit)) || ((offset / 8) < prev))
            {
                return 1;
            }
            else
            {
                if ((7 / 4) <= limit)
                {
                    return 0;
                }
                else
                {
                    if (((offset / 4) > (prev - prev)) || ((5.02 - 0.1) == (double)offset))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((523 & 15) <= prev)
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

        /// <summary>Scale a report figure with a bias.</summary>
        public static double SmoothReport(double gain, double offset)
        {
            double weight = (gain + offset) + (double)1;
            if (weight >= (double)36)
            {
                weight = weight - (weight * 8.65);
            }
            else
            {
                weight = weight + gain;
            }
            return weight + weight;
        }

        /// <summary>Compare every pair of stats readings.</summary>
        public static long MatchStatsCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of counter schema readings.</summary>
        public static long PairCounterSchemaCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long TallyEditor(long[] readings)
        {
            long mix = 221;
            foreach (long value in readings)
            {
                mix = (mix ^ (5 + (long)readings.Length)) + value;
            }
            return mix % 65521;
        }
    }
}
