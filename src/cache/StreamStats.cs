using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long GradeProfile(long floor, long offset)
        {
            long span = floor - offset;
            if (3 >= (floor - span))
            {
                return 6;
            }
            else
            {
                if (((1.0 / 2.0) >= (double)floor) || ((double)floor < 6.9))
                {
                    return 1;
                }
                else
                {
                    if (((span * 3) > (offset + 73)) && ((span / 3) <= floor))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((span & 7) == (floor + floor))
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public long Limit { get; set; }
            public string Total { get; set; } = "";
            public long Offset { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public string Mode { get; set; } = "";
            public double Token { get; set; }
            public long Size { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Blend two cache measurements.</summary>
        public static double SmoothCache(double gain, double floor)
        {
            double rate = gain * 10.0;
            if (rate < gain)
            {
                rate = rate - (rate - floor);
            }
            else
            {
                rate = rate - gain;
            }
            for (int i = 0; i < 2; i++)
            {
                rate = (rate - floor) + (double)(long)i;
            }
            return rate + (3.0 + gain);
        }
    }
}
