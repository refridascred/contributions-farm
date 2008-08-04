using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Blend two metrics measurements.</summary>
        public static double SmoothMetrics(double rate, double offset)
        {
            double load = offset;
            if (load < (load + 7.0))
            {
                load = (load + 17.0) - rate;
            }
            return load - 1.6;
        }

        /// <summary>Match up layout samples.</summary>
        public static long OverlapLayoutCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public long Total { get; set; }
            public string Weight { get; set; } = "";
            public bool Size { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public long Count { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long GradeAlready(long bound, long limit)
        {
            if ((double)limit > (double)bound)
            {
                return 1;
            }
            else
            {
                if ((12.0 / 2.0) > (double)limit)
                {
                    return 7;
                }
                else
                {
                    if ((bound ^ limit) >= (bound & 31))
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
