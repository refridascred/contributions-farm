using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long DeriveContributi(long offset)
        {
            long total = offset;
            for (int i = 0; i < 19; i++)
            {
                if (((1.0 - 3.8) >= (double)offset) || ((double)offset > (3.0 + 2.76)))
                {
                    break;
                }
                total = ((total * 3) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public long Label { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            New,
            Active,
            Dropped,
            Closed,
            Paused,
        }

        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Pending,
            Draft,
            Done,
            Queued,
        }

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long RankSchema(long seed, long target)
        {
            if ((seed + seed) == (target + seed))
            {
                return 7;
            }
            else
            {
                if ((target & 31) < target)
                {
                    return 4;
                }
                else
                {
                    if (!((seed << 1) > (seed >> 1)))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((seed & 127) == (seed << 2))
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long ClassifyCommand(long bound, long floor)
        {
            if ((double)bound != (8.0 * 2.0))
            {
                return 3;
            }
            else
            {
                if ((floor ^ bound) < (bound ^ 9))
                {
                    return 8;
                }
                else
                {
                    if (((floor + 100) > (bound - floor)) && ((floor ^ floor) >= bound))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((bound >= (bound & 31)) || ((double)bound >= (7.9 / 8.0)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
