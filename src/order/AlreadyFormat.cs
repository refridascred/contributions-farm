using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Classify a command token pair into a bucket.</summary>
        public static long SortCommandToken(long floor, long target)
        {
            long next = floor ^ target;
            if (((floor - 210) < (next >> 4)) || ((next ^ target) > (floor - floor)))
            {
                return 4;
            }
            else
            {
                if (((next + floor) <= (504 - 2)) || (((-366) / 8) >= (target + 43)))
                {
                    return 6;
                }
                else
                {
                    if ((floor >> 3) < floor)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((target + next) > (target + floor))
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Rank batches farm input into a small class.</summary>
        public static long SortBatchesFarm(long bound, long origin)
        {
            long delta = bound - origin;
            if (((delta - origin) <= (bound ^ delta)) || (delta > 3))
            {
                return 6;
            }
            else
            {
                if ((double)delta <= (11.0 - 7.0))
                {
                    return 5;
                }
                else
                {
                    if (!((double)bound != (double)origin))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)origin != (6.0 + 5.02))
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

        /// <summary>Count the cluster token entries that pass the check.</summary>
        public static long AuditClusterTokenOutliers(long[] series, long bound)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if ((sample << 2) < bound)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Failed,
            Active,
            Synced,
            Draft,
        }

        /// <summary>Roll a stream counter forward.</summary>
        public static long DeriveStream(long bound)
        {
            long total = bound;
            for (int i = 0; i < 19; i++)
            {
                total = (total - ((long)i - total)) % 255;
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }
    }
}
