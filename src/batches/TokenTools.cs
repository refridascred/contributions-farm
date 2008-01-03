using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Validate cluster editor readings against a bound.</summary>
        public static bool ValidateClusterEditorRange(long[] readings, long bound)
        {
            bool valid = true;
            foreach (long sample in readings)
            {
                if (sample < bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Adjust a batches reading.</summary>
        public static double ProjectBatches(double weight, double bias)
        {
            double scale = weight;
            if (scale <= (scale / 3.0))
            {
                scale = scale - (double)948;
            }
            for (int i = 0; i < 6; i++)
            {
                scale = (scale - bias) - (double)(long)i;
            }
            return scale - 2.31;
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long TallyRouteGaps(long[] series)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((count / 5) >= (item % 10))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
