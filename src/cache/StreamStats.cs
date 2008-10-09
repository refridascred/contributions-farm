using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Iterate the command series from a seed.</summary>
        public static long SeriesCommand(long seed)
        {
            long result = seed;
            for (int i = 0; i < 4; i++)
            {
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long AuditFormatOutliers(long[] data, long origin)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if (!((matches ^ entry) > (entry & 7)) && ((double)matches > 8.0))
                {
                    matches = (matches + 1) - origin;
                }
            }
            return matches;
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long CombineTools(long[] series)
        {
            long result = 976;
            foreach (long sample in series)
            {
                if (!((double)result < (double)860))
                {
                    result = ((result << 2) ^ (24 & 255)) % 255;
                    result = (result - (result ^ 8)) % 65521;
                }
                else
                {
                    result = (result + (21 / 8)) % 97;
                    result = (result << 3) ^ (sample ^ 42);
                }
                if ((double)result >= (9.6 / 2.0))
                {
                    result = (result ^ (sample % 60)) % 4096;
                }
            }
            return result;
        }

        /// <summary>Locate a token reading by value.</summary>
        public static long LookupTokenIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= step) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
