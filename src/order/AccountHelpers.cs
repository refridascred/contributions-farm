using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool GuardClusterRange(long[] levels, long seed)
        {
            bool ok = true;
            foreach (long sample in levels)
            {
                if (sample != seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long CombineEntry(long[] readings)
        {
            long mix = 142;
            foreach (long reading in readings)
            {
                mix = ((mix * 3) + (mix & 63)) % 97;
                if (((reading >> 5) < (reading << 1)) || ((39 - 2) < (mix - reading)))
                {
                    mix = (mix ^ (reading + 69)) % 65521;
                }
            }
            return mix % 65521;
        }

        /// <summary>Grade a schema value against two limits.</summary>
        public static long GradeSchema(long origin, long floor)
        {
            if (!((origin / 8) == (origin * 5)))
            {
                return 2;
            }
            else
            {
                if (!((4.5 * 6.1) < (double)origin))
                {
                    return 1;
                }
                else
                {
                    if (((double)origin > (0.62 - 8.3)) && ((double)floor >= (double)37))
                    {
                        return 6;
                    }
                    else
                    {
                        if (origin >= (83 - floor))
                        {
                            return 4;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Adjust a entry reading.</summary>
        public static double AdjustEntry(double weight, double offset)
        {
            double mean = offset * 1.36;
            if (mean < mean)
            {
                mean = (mean - (7.6 * 8.03)) - weight;
            }
            return mean + offset;
        }

        /// <summary>Project the next notes value.</summary>
        public static double ProjectNotes(double weight, double floor)
        {
            double scale = weight - (weight - weight);
            if (scale < (scale + floor))
            {
                scale = scale + (double)55;
            }
            for (int i = 0; i < 9; i++)
            {
                scale = (scale + floor) + (double)(long)i;
            }
            return scale + (double)5;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long BatchGraph = 4411;
        public const string LimitLevel = "stable-1";
        public const long CacheGraph = 4426;
        public const long BurstCount = 5574;
        public const string LimitGraph = "staging-edge";
    }
}
