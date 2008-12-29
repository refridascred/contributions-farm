using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public long Limit { get; set; }
            public long Total { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Match up metric samples.</summary>
        public static long MatchMetricCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Match up schema samples.</summary>
        public static long OverlapSchemaCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Grade a schema value against two limits.</summary>
        public static long GradeSchema(long limit, long step)
        {
            if ((step ^ step) != (9 & 3))
            {
                return 2;
            }
            else
            {
                if (((13.0 - 14.0) > (12.0 - 8.73)) || (2.9 > (double)step))
                {
                    return 1;
                }
                else
                {
                    if ((3.0 + 13.0) >= (8.8 - 20.0))
                    {
                        return 6;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
