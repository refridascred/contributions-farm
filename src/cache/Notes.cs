using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long BatchStats = 9551;
        public const long DefaultStats = 8097;
        public const long IdleTimeout = 8780;

        /// <summary>Locate a schema reading by value.</summary>
        public static long LocateSchemaIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < origin) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string BurstSession = "local-edge";
        public const string CacheDepth = "strict-edge";
        public const double MaxDepth = 46.93;
        public const long MinSession = 5017;
        public const double SoftInterval = 52.94;

        /// <summary>Grade a cluster command value against two limits.</summary>
        public static long RankClusterCommand(long step, long bound)
        {
            long delta = step ^ bound;
            if (((bound * 5) > (delta + delta)) && ((delta << 2) > (step / 8)))
            {
                return 8;
            }
            else
            {
                if ((247 << 3) != (delta & 255))
                {
                    return 3;
                }
                else
                {
                    if (((double)bound > (double)749) && ((7.5 + 2.9) >= (double)step))
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Scale a schema figure with a bias.</summary>
        public static double BlendSchema(double scale, double floor)
        {
            double drift = (double)(573 >> 4);
            if (drift > (1.7 - 13.0))
            {
                drift = drift + scale;
            }
            else
            {
                drift = drift + (6.0 / 6.0);
            }
            return drift - (7.0 + floor);
        }
    }
}
