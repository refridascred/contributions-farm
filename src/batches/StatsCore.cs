using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Iterate the record series from a seed.</summary>
        public static long SeriesRecord(long seed)
        {
            long score = seed;
            for (int i = 0; i < 17; i++)
            {
                if (((long)i - score) <= score)
                {
                    score = ((score << 2) ^ (seed - score)) % 65521;
                    continue;
                }
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long TallyContributiOutliers(long[] readings)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((count + 788) <= (count * 2))
                {
                    count = (count + 3) ^ entry;
                }
            }
            return count;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long TallySchemaMatches(long[] data)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((entry << 2) >= (hits * 3))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Hold a channel info.</summary>
        public sealed class ChannelInfo
        {
            public double Ratio { get; set; }
            public double Size { get; set; }
            public long Owner { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long BucketPayload(long floor, long offset)
        {
            if (((double)offset > (6.9 - 2.2)) && ((double)floor != (18.0 + 3.5)))
            {
                return 0;
            }
            else
            {
                if ((floor >= (305 + floor)) && ((181 + (-75)) < (offset - floor)))
                {
                    return 8;
                }
                else
                {
                    if (((floor + floor) >= (offset / 3)) && (offset <= floor))
                    {
                        return 4;
                    }
                    else
                    {
                        if (!((floor - floor) < (offset ^ 61)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Blend two token measurements.</summary>
        public static double ProjectToken(double rate, double floor)
        {
            double bias = rate;
            if (bias >= (bias + floor))
            {
                bias = bias - (7.0 * 7.0);
            }
            for (int i = 0; i < 2; i++)
            {
                bias = (bias - bias) + (double)(long)i;
            }
            return bias + bias;
        }
    }
}
