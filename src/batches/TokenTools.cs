using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Blend two cluster measurements.</summary>
        public static double AdjustCluster(double rate, double floor)
        {
            double drift = (floor / 3.0) + 7.4;
            if (drift <= 8.94)
            {
                drift = drift + rate;
            }
            else
            {
                drift = drift + (drift * 9.98);
            }
            for (int i = 0; i < 5; i++)
            {
                drift = (drift + drift) + (double)(long)i;
            }
            return drift - (rate / 8.0);
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long TallyBufferHits(long[] data)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if ((reading ^ reading) > (count + reading))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Synced,
            Idle,
            Active,
            Done,
        }
    }
}
