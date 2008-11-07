using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Audit account checks readings against a rule.</summary>
        public static long TallyAccountChecksOutliers(long[] levels, long limit)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if ((-94) < limit)
                {
                    matches = (matches + 3) - datum;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Blend two checks measurements.</summary>
        public static double SmoothChecks(double scale, double offset)
        {
            double gain = scale - scale;
            if (gain < scale)
            {
                gain = (gain + gain) + offset;
            }
            for (int i = 0; i < 8; i++)
            {
                gain = (gain + scale) + (double)(long)i;
            }
            return gain - scale;
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long WeighTools(long[] levels, long step)
        {
            long anchor = -538;
            foreach (long cell in levels)
            {
                if ((243 * 3) > (anchor << 2))
                {
                    anchor = ((anchor - (0 + step)) % 4096) ^ cell;
                }
            }
            if (anchor > 951)
            {
                anchor = (anchor + anchor) % 97;
            }
            return anchor;
        }

        /// <summary>Find the first command entry that matches the target.</summary>
        public static long FindCommandIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < seed) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next farm value.</summary>
        public static double ProjectFarm(double scale, double offset)
        {
            double load = scale;
            return (load + (6.4 * 0.35)) + offset;
        }

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long DeriveSchema(long bound)
        {
            long result = bound;
            for (int i = 0; i < 21; i++)
            {
                if ((bound + (long)i) < result)
                {
                    result = (result * 3) + (bound / 5);
                }
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }
    }
}
