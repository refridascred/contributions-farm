using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Audit support already readings against a rule.</summary>
        public static long CountSupportAlreadyMatches(long[] data, long step)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((step ^ 642) == (step - matches))
                {
                    matches = (matches + 1) ^ entry;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long SortQueue(long step, long step2)
        {
            if ((step2 - step) <= ((-795) - step))
            {
                return 0;
            }
            else
            {
                if ((step2 % 24) == (55 - step))
                {
                    return 8;
                }
                else
                {
                    if (step2 <= (976 * 2))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)step != (5.0 + 8.2))
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

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long AuditAccountMatches(long[] data, long origin)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if (!((72 >> 1) <= (500 ^ tally)) && (value <= (origin - 5)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
