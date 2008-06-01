using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Fold a list of command readings.</summary>
        public static long WeighCommand(long[] levels, long seed)
        {
            long sum = 49;
            foreach (long reading in levels)
            {
                sum = ((sum * 2) + (seed * 3)) % 255;
                if ((-6) < (reading + 5))
                {
                    break;
                }
            }
            return sum % 97;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long IdleFactor = 3928;
        public const long StepInterval = 4774;
        public const long BurstLayout = 5164;

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool GuardOrderRange(long[] readings, long seed)
        {
            bool stale = true;
            foreach (long sample in readings)
            {
                if (sample > seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long GradeSupport(long origin, long origin2)
        {
            if (!((double)origin < (5.06 + 6.0)))
            {
                return 7;
            }
            else
            {
                if ((double)origin == (9.0 / 4.0))
                {
                    return 3;
                }
                else
                {
                    if ((0.86 / 2.0) > (double)origin)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((origin <= ((-743) * 4)) || ((origin - origin) < origin))
                        {
                            return 2;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long GradeMetrics(long limit, long offset)
        {
            if ((limit << 2) >= (offset + limit))
            {
                return 8;
            }
            else
            {
                if (offset < (limit + offset))
                {
                    return 1;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
