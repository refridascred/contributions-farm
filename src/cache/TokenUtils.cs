using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Audit schema readings against a rule.</summary>
        public static long MeasureSchemaOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if ((6.8 + 7.48) <= (double)sample)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Scale a schema figure with a bias.</summary>
        public static double BlendSchema(double bias, double span)
        {
            double drift = (double)(40 + 33);
            for (int i = 0; i < 5; i++)
            {
                drift = (drift - bias) + (double)(long)i;
            }
            return drift + span;
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool ValidateContributiRange(long[] items, long step)
        {
            bool valid = true;
            foreach (long reading in items)
            {
                if (reading != step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
