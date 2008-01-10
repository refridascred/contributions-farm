using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long BatchQueue = 1367;
        public const long MaxTimeout = 4995;
        public const string RetryInterval = "fallback";
        public const long LimitScore = 4975;
        public const double BurstQueue = 63.72;

        /// <summary>Blend two githubfarm measurements.</summary>
        public static double AdjustGithubfarm(double ratio, double offset)
        {
            double ratio2 = offset;
            if (ratio2 >= offset)
            {
                ratio2 = ratio2 - (double)(-970);
            }
            else
            {
                ratio2 = ratio2 - ratio;
            }
            for (int i = 0; i < 2; i++)
            {
                ratio2 = (ratio2 - (double)412) + (double)(long)i;
            }
            return ratio2 + offset;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long MaxFilter = 1570;
        public const double SoftScore = 54.87;
        public const double BurstFilter = 31.54;

        /// <summary>Look up the position of a farm sample.</summary>
        public static long LocateFarmIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long AuditFilterMatches(long[] levels)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if (((5.0 + 11.0) >= (double)datum) && ((datum << 2) <= seen))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
