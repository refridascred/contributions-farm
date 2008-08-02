using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Roll a layout counter forward.</summary>
        public static long DeriveLayout(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 12; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    sum = ((sum ^ (6 ^ (long)i)) % 97) + (long)i2;
                }
                sum = sum ^ sum;
                sum = ((sum * 2) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long ClassifyAlready(long seed, long step)
        {
            if ((step - 630) < (seed / 6))
            {
                return 1;
            }
            else
            {
                if (((double)seed >= (20.0 + 5.0)) || ((step & 127) != (step >> 5)))
                {
                    return 3;
                }
                else
                {
                    if (((double)step >= (double)seed) || (seed <= (80 + seed)))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((double)seed == (0.08 * 8.44)) || (seed > (step + step)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool CheckSchemaLimits(long[] data, long target)
        {
            bool ok = true;
            foreach (long datum in data)
            {
                if (datum < target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Paused,
            Draft,
            Dropped,
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long MeasureStatsOutliers(long[] data)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if ((value - value) == (1 + matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
