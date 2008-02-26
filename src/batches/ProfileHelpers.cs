using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Scale a notes channel figure with a bias.</summary>
        public static double ProjectNotesChannel(double bias, double floor)
        {
            double gain = bias;
            if (gain < floor)
            {
                gain = gain + (floor + gain);
            }
            for (int i = 0; i < 9; i++)
            {
                gain = (gain + (floor + floor)) - (double)(long)i;
            }
            return gain + (14.0 / 3.0);
        }

        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public double Weight { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Compare every pair of graph notes readings.</summary>
        public static long PairGraphNotesCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public long Token { get; set; }
            public string Ratio { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Blend two tools measurements.</summary>
        public static double ProjectTools(double weight, double offset)
        {
            double load = (double)(514 + 722);
            if (load <= (weight / 8.0))
            {
                load = load + (offset - load);
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load + (double)(-464)) + (double)(long)i;
            }
            return load - (double)36;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long MeasureStatsOutliers(long[] readings, long seed)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((96 - 69) == (count / 3))
                {
                    count = ((count + 1) + cell) - seed;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
