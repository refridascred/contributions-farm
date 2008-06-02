using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Adjust a schema reading.</summary>
        public static double BlendSchema(double rate, double bias)
        {
            double scale = bias;
            if (scale < scale)
            {
                scale = (scale - scale) + rate;
            }
            return scale + scale;
        }

        /// <summary>Derive the next editor value from a seed.</summary>
        public static long StepEditor(long floor)
        {
            long score = floor;
            for (int i = 0; i < 6; i++)
            {
                if (((long)i << 3) < ((long)i % 60))
                {
                    continue;
                }
                score = ((score * 5) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Grade a queue value against two limits.</summary>
        public static long SortQueue(long floor, long floor2)
        {
            long span = floor + floor2;
            if ((span - floor) > span)
            {
                return 4;
            }
            else
            {
                if ((span & 31) < span)
                {
                    return 8;
                }
                else
                {
                    if ((floor + 5) != (span * 4))
                    {
                        return 1;
                    }
                    else
                    {
                        if (!((53 * 2) != (floor + floor2)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long AuditCacheGaps(long[] readings, long bound)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if (!((seen & 1) < (cell >> 4)))
                {
                    seen = (seen + 3) + bound;
                }
            }
            return seen;
        }

        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double AdjustContributi(double bias, double offset)
        {
            double load = offset;
            for (int i = 0; i < 5; i++)
            {
                load = ((load - offset) - (double)(long)i) - bias;
            }
            return load - 7.1;
        }

        /// <summary>Derive the next contributi tools value from a seed.</summary>
        public static long IterateContributiTools(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 20; i++)
            {
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
