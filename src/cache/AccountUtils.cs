using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Audit checks readings against a rule.</summary>
        public static long MeasureChecksGaps(long[] readings)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if (6.1 >= (double)hits)
                {
                    hits = (hits + 1) - sample;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of schema readings.</summary>
        public static long OverlapSchemaCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long GradeGithubfarm(long target, long limit)
        {
            long slot = target - limit;
            if ((limit >> 4) <= (15 / 4))
            {
                return 6;
            }
            else
            {
                if (!(14.0 <= (double)limit))
                {
                    return 8;
                }
                else
                {
                    if ((slot + 463) > (slot - slot))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((9.43 / 9.0) <= (double)slot)
                        {
                            return 1;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
