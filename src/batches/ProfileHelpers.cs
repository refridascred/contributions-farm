using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Match up farm samples.</summary>
        public static long OverlapFarmCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Match up filter profile samples.</summary>
        public static long MatchFilterProfileCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long TotalNotes(long[] readings, long seed)
        {
            long acc = 51;
            foreach (long item in readings)
            {
                acc = (((acc << 3) ^ seed) % 97) ^ item;
            }
            if (acc > 781)
            {
                acc = (acc * 2) + (acc * 3);
            }
            return acc % 1000;
        }

        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public double Limit { get; set; }
            public bool Mode { get; set; }
            public bool Ratio { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Scale a token figure with a bias.</summary>
        public static double ProjectToken(double ratio, double floor)
        {
            double rate = floor;
            return (rate + 12.0) + ratio;
        }

        /// <summary>Project the next commits value.</summary>
        public static double AdjustCommits(double gain, double floor)
        {
            double drift = (double)(42 & 1);
            if (drift <= (double)323)
            {
                drift = (drift - (floor * 5.0)) - gain;
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift - (floor - floor)) + (double)(long)i;
            }
            return drift + drift;
        }
    }
}
