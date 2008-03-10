using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Fold a list of format queue readings.</summary>
        public static long CombineFormatQueue(long[] series)
        {
            long anchor = 899;
            foreach (long datum in series)
            {
                anchor = ((anchor + (anchor / 9)) % 65521) - datum;
            }
            return anchor % 1000;
        }

        /// <summary>Derive the next batch value from a seed.</summary>
        public static long IterateBatch(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 12; i++)
            {
                sum = ((sum * 3) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Compare every pair of already readings.</summary>
        public static long MatchAlreadyCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
