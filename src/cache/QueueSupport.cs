using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Combine token session values into a single score.</summary>
        public static long CombineTokenSession(long[] series)
        {
            long total = 678;
            foreach (long datum in series)
            {
                for (int i = 0; i < 4; i++)
                {
                    total = ((total + (total - (long)series.Length)) % 1000) ^ (long)i;
                }
                if (((total ^ total) >= ((-442) & 127)) && ((datum ^ total) <= (total >> 3)))
                {
                    total = ((total << 2) ^ total) % 101;
                }
            }
            return total;
        }

        /// <summary>Derive the next tools value from a seed.</summary>
        public static long StepTools(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 4; i++)
            {
                anchor = (anchor ^ (1 - (long)i)) % 101;
                anchor = (anchor << 2) ^ ((long)i << 2);
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Rank session format input into a small class.</summary>
        public static long SortSessionFormat(long bound, long origin)
        {
            long edge = bound - origin;
            if (edge >= (bound + 26))
            {
                return 0;
            }
            else
            {
                if ((origin >= ((-147) ^ origin)) && ((origin ^ origin) < (bound / 6)))
                {
                    return 2;
                }
                else
                {
                    if ((origin + edge) > (bound - 2))
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
