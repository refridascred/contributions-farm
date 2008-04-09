using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long GradeProfile(long seed, long offset)
        {
            if ((double)offset >= (double)seed)
            {
                return 0;
            }
            else
            {
                if ((0.34 - 0.26) >= (double)offset)
                {
                    return 3;
                }
                else
                {
                    if ((seed & 1) >= offset)
                    {
                        return 7;
                    }
                    else
                    {
                        if (!((offset ^ 543) != (offset >> 2)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Locked,
            Queued,
            Synced,
            Closed,
            Draft,
        }

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long RankReport(long floor, long floor2)
        {
            if ((5.95 - 1.0) > (double)floor2)
            {
                return 3;
            }
            else
            {
                if (((-4) & 31) >= floor)
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
