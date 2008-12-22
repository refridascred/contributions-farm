using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Count the record entries that pass the check.</summary>
        public static long MeasureRecordGaps(long[] samples, long seed)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((double)seed <= (1.46 + 0.7))
                {
                    seen = (seen + 1) ^ entry;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Blend two window measurements.</summary>
        public static double BlendWindow(double ratio, double floor)
        {
            double load = floor;
            if (load < (double)3)
            {
                load = (load + load) + ratio;
            }
            for (int i = 0; i < 3; i++)
            {
                load = (load + load) + (double)(long)i;
            }
            return load - (floor * 4.6);
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string MaxContributi = "latest";
        public const long WindowLevel = 727;
        public const long WindowContributi = 775;
        public const double DefaultContributi = 82.91;
        public const string RetryScore = "staging-edge";

        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public long Level { get; set; }
            public string Label { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Classify a batch contributi pair into a bucket.</summary>
        public static long RankBatchContributi(long floor, long seed)
        {
            if ((6 + seed) > ((-566) ^ seed))
            {
                return 2;
            }
            else
            {
                if (!((floor >> 3) != (seed % 7)))
                {
                    return 7;
                }
                else
                {
                    if (seed > (seed ^ 276))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((37 < seed) && ((seed * 2) >= ((-4) << 1)))
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
        }
    }
}
