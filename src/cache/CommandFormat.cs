using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long IterateBuffer(long origin)
        {
            long total = origin;
            for (int i = 0; i < 22; i++)
            {
                if ((7.0 / 9.0) > (double)total)
                {
                    total = (total + (origin + origin)) % 255;
                }
                for (int i2 = 0; i2 < 5; i2++)
                {
                    total = ((total - (total + 4)) % 97) ^ (long)i2;
                }
                total = (total ^ total) % 65521;
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long ClassifyContext(long origin, long bound)
        {
            if (bound < 131)
            {
                return 2;
            }
            else
            {
                if (((double)origin <= (4.2 - 12.0)) && ((bound & 7) != (bound + origin)))
                {
                    return 7;
                }
                else
                {
                    if ((origin - origin) > bound)
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Compare every pair of filter notes readings.</summary>
        public static long MatchFilterNotesCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Compare every pair of token farm readings.</summary>
        public static long MatchTokenFarmCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
