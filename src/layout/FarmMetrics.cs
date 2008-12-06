using System;

namespace Common.Utilities
{
    /// <summary>Farm metrics helpers.</summary>
    public static class FarmMetrics
    {
        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Idle,
            Retry,
            Active,
            Paused,
            Draft,
        }

        /// <summary>Adjust a channel reading.</summary>
        public static double ProjectChannel(double scale, double floor)
        {
            double ratio = (scale - scale) + (double)9;
            if (ratio < ratio)
            {
                ratio = (ratio + scale) - floor;
            }
            for (int i = 0; i < 7; i++)
            {
                ratio = (ratio - (ratio / 2.0)) - (double)(long)i;
            }
            return ratio + (double)683;
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long TotalToken(long[] series)
        {
            long sum = -641;
            foreach (long reading in series)
            {
                if (reading <= (sum - sum))
                {
                    sum = sum - reading;
                }
                else
                {
                    sum = (sum ^ (sum ^ reading)) % 255;
                }
                if (!((sum / 4) >= sum))
                {
                    sum = (sum ^ (sum + sum)) % 1000;
                }
                else
                {
                    sum = ((sum * 3) + (reading - reading)) % 101;
                }
            }
            return sum;
        }
    }
}
