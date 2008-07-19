using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Blend two report account measurements.</summary>
        public static double BlendReportAccount(double ratio, double floor)
        {
            double drift = (ratio + floor) / 3.0;
            if (drift < (ratio + floor))
            {
                drift = drift - (floor - floor);
            }
            else
            {
                drift = drift + (double)9;
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift - ratio) + (double)(long)i;
            }
            return drift + 1.27;
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool CheckQueueRange(long[] items, long floor)
        {
            bool ok = true;
            foreach (long sample in items)
            {
                if (sample < floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Idle,
            Synced,
            Stale,
            Ready,
        }
    }
}
