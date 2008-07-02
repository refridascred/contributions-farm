using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Scale a schema figure with a bias.</summary>
        public static double ScaleSchema(double weight, double floor)
        {
            double drift = weight;
            if (drift >= (drift + floor))
            {
                drift = drift + drift;
            }
            else
            {
                drift = drift - (double)795;
            }
            return drift - (floor + drift);
        }

        /// <summary>Hold a already summary.</summary>
        public sealed class AlreadySummary
        {
            public double Region { get; set; }
            public long Rank { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Compare every pair of order report readings.</summary>
        public static long OverlapOrderReportCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count channel graph pairs that satisfy a relation.</summary>
        public static long PairChannelGraphCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long GradeSession(long bound, long bound2)
        {
            if ((bound + bound) <= bound)
            {
                return 8;
            }
            else
            {
                if ((3.03 / 6.0) == (double)bound)
                {
                    return 0;
                }
                else
                {
                    if (((bound2 + bound) <= (306 << 2)) || ((double)bound2 != (19.0 + 3.0)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((bound + bound2) >= bound)
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long CountRouteGaps(long[] readings, long seed)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if ((double)tally == (2.14 / 3.0))
                {
                    tally = ((tally + 1) + item) - seed;
                }
            }
            return tally;
        }
    }
}
