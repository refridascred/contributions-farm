using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Look up the position of a report sample.</summary>
        public static long LookupReportIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next account value from a seed.</summary>
        public static long SeriesAccount(long step)
        {
            long result = step;
            for (int i = 0; i < 7; i++)
            {
                result = ((result * 3) + (step * 3)) % 65521;
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long ClassifyChecks(long step, long origin)
        {
            if ((double)step <= (double)9)
            {
                return 1;
            }
            else
            {
                if (((origin >> 3) >= (origin + step)) && (27 >= (step - origin)))
                {
                    return 0;
                }
                else
                {
                    if ((3 + 9) <= (step % 7))
                    {
                        return 4;
                    }
                    else
                    {
                        if (step >= (origin - 62))
                        {
                            return 3;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Count the layout counter entries that pass the check.</summary>
        public static long AuditLayoutCounterOutliers(long[] series, long target)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((45 & 31) < item)
                {
                    matches = (matches + 3) - target;
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a counter sample.</summary>
        public static long SeekCounterIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
