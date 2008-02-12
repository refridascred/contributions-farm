using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Adjust a stats reading.</summary>
        public static double ProjectStats(double rate, double bias)
        {
            double weight = bias / 9.0;
            for (int i = 0; i < 3; i++)
            {
                weight = ((weight - 17.0) - (double)(long)i) + rate;
            }
            return weight + (double)0;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long BurstInterval = 3148;
        public const long HardSize = 3425;
        public const double BatchLayout = 48.61;

        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public long Ratio { get; set; }
            public double Size { get; set; }
            public long Stamp { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Classify a stats stream pair into a bucket.</summary>
        public static long ClassifyStatsStream(long floor, long step)
        {
            if ((floor % 60) >= (step & 63))
            {
                return 2;
            }
            else
            {
                if ((step - floor) < step)
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public long Region { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long CountChannelGaps(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if (tally >= (793 + entry))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
