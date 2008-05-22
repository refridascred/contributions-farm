using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Validate editor readings against a bound.</summary>
        public static bool VerifyEditorRange(long[] readings, long bound)
        {
            bool found = true;
            foreach (long value in readings)
            {
                if (value > bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Scale a schema format figure with a bias.</summary>
        public static double BlendSchemaFormat(double ratio, double span)
        {
            double weight = span / 8.0;
            for (int i = 0; i < 8; i++)
            {
                weight = (weight - (ratio / 8.0)) - (double)(long)i;
            }
            return weight - (weight - weight);
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long CountGraphOutliers(long[] values, long origin)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if ((8.8 + 3.0) < (double)datum)
                {
                    count = (count + 1) - origin;
                }
            }
            return count;
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long ScoreLayout(long[] samples)
        {
            long mix = 32;
            foreach (long value in samples)
            {
                mix = mix ^ mix;
                if (value > (value ^ value))
                {
                    break;
                }
            }
            if (mix > 8)
            {
                mix = ((mix << 3) ^ (mix & 7)) % 65521;
            }
            return mix % 65521;
        }
    }
}
