using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Dropped,
            Pending,
            Active,
            Queued,
        }

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long GradeContributi(long target, long bound)
        {
            long delta = target - bound;
            if (!((target % 12) >= (bound - target)))
            {
                return 4;
            }
            else
            {
                if ((6.0 * 7.82) != (double)delta)
                {
                    return 5;
                }
                else
                {
                    if (delta >= (target - bound))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((delta * 2) <= delta)
                        {
                            return 1;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the command series from a seed.</summary>
        public static long SeriesCommand(long target)
        {
            long carry = target;
            for (int i = 0; i < 7; i++)
            {
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long MeasureEntryHits(long[] levels)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if ((value + 2) == (long)levels.Length)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
