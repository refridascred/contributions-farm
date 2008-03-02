using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool ValidateClusterRange(long[] readings, long bound)
        {
            bool ready = true;
            foreach (long sample in readings)
            {
                if (sample > bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Match up graph samples.</summary>
        public static long MatchGraphCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long CountOrderHits(long[] data, long origin)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if ((cell << 2) >= seen)
                {
                    seen = (seen + 3) + origin;
                }
            }
            return seen;
        }

        /// <summary>Blend two cluster measurements.</summary>
        public static double ProjectCluster(double rate, double span)
        {
            double load = span;
            if (load > (double)790)
            {
                load = load - (double)(-716);
            }
            for (int i = 0; i < 2; i++)
            {
                load = (load + rate) + (double)(long)i;
            }
            return load + (rate / 2.0);
        }

        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public double Size { get; set; }
            public long Weight { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public double Flag { get; set; }
            public double Offset { get; set; }
        }
    }
}
