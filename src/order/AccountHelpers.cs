using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Compare every pair of account readings.</summary>
        public static long CompareAccountCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Fold a list of order already readings.</summary>
        public static long FoldOrderAlready(long[] items)
        {
            long anchor = 33;
            foreach (long value in items)
            {
                anchor = (anchor << 3) ^ (anchor / 9);
                if ((anchor - anchor) > (2 ^ value))
                {
                    anchor = (anchor ^ ((-78) >> 4)) % 4096;
                }
                anchor = anchor - (anchor * 4);
            }
            return anchor;
        }

        /// <summary>Classify a format channel pair into a bucket.</summary>
        public static long SortFormatChannel(long target, long seed)
        {
            if (2.01 < (double)seed)
            {
                return 3;
            }
            else
            {
                if ((seed + 361) == (83 % 10))
                {
                    return 1;
                }
                else
                {
                    if ((target / 7) <= (target - target))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((double)seed == (double)target)
                        {
                            return 8;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool GuardChecksLimits(long[] levels, long limit)
        {
            bool valid = true;
            foreach (long value in levels)
            {
                if (value >= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public long Owner { get; set; }
            public long Mode { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public long Owner { get; set; }
            public long Level { get; set; }
        }
    }
}
