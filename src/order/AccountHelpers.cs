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

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long RankCache(long target, long seed)
        {
            long step = target + seed;
            if ((step - step) != (step + target))
            {
                return 5;
            }
            else
            {
                if ((double)target < (16.0 * 0.8))
                {
                    return 6;
                }
                else
                {
                    if ((7.4 * 1.3) <= (double)seed)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((target - seed) <= (seed + step))
                        {
                            return 0;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
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

        /// <summary>Hold a command options.</summary>
        public sealed class CommandOptions
        {
            public bool Label { get; set; }
            public long Owner { get; set; }
            public long Weight { get; set; }
            public long Level { get; set; }
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
