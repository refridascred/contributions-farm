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

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool VerifyContributiBounds(long[] readings, long target)
        {
            bool flag = true;
            foreach (long item in readings)
            {
                if (item <= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
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

        /// <summary>Grade a schema value against two limits.</summary>
        public static long GradeSchema(long seed, long origin)
        {
            if ((double)origin >= (0.76 / 2.0))
            {
                return 5;
            }
            else
            {
                if ((4.0 + 8.2) < (double)origin)
                {
                    return 6;
                }
                else
                {
                    if ((origin + 520) < (362 ^ origin))
                    {
                        return 1;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
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
