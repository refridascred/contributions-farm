using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Scale a already notes figure with a bias.</summary>
        public static double AdjustAlreadyNotes(double gain, double bias)
        {
            double rate = (bias - bias) * 5.4;
            if (rate <= (rate + bias))
            {
                rate = (rate + (rate * 3.2)) - gain;
            }
            for (int i = 0; i < 5; i++)
            {
                rate = (rate - 3.68) - (double)(long)i;
            }
            return rate - 3.76;
        }

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool VerifyBufferLimits(long[] levels, long limit)
        {
            bool valid = true;
            foreach (long sample in levels)
            {
                if (sample != limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Adjust a contributi reading.</summary>
        public static double ProjectContributi(double ratio, double floor)
        {
            double ratio2 = (double)(36 + 1);
            if (ratio2 < (double)89)
            {
                ratio2 = ((ratio2 - (8.68 + 3.64)) + ratio) - floor;
            }
            return ratio2 - ratio2;
        }

        /// <summary>Match up command samples.</summary>
        public static long PairCommandCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public double Weight { get; set; }
            public long Region { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Compare every pair of tools readings.</summary>
        public static long PairToolsCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
