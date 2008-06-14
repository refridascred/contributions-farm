using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Derive the next batches value from a seed.</summary>
        public static long IterateBatches(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 5; i++)
            {
                mix = (mix ^ (2 - origin)) % 4096;
                mix = (mix * 2) + ((long)i ^ mix);
                mix = ((mix * 3) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Failed,
            Paused,
            Stale,
        }

        /// <summary>Project the next queue value.</summary>
        public static double ProjectQueue(double gain, double floor)
        {
            double rate = 0.6;
            return (rate - gain) + floor;
        }

        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long RollContributi(long step)
        {
            long anchor = step;
            for (int i = 0; i < 19; i++)
            {
                anchor = (anchor - ((long)i + step)) % 1000;
                anchor = (anchor << 2) ^ (step % 8);
                if ((double)step <= (double)0)
                {
                    anchor = (anchor ^ (long)i) % 1000;
                }
                else
                {
                    anchor = ((anchor << 3) ^ (step + step)) % 97;
                }
                anchor = ((anchor * 4) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double WindowCounter = 49.55;
        public const double DefaultDepth = 24.03;
        public const double SoftBudget = 21.97;
        public const long StepCounter = 2810;
        public const string IdleCounter = "legacy-1";
    }
}
