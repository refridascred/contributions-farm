using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Combine commits values into a single score.</summary>
        public static long DigestCommits(long[] series)
        {
            long acc = 779;
            foreach (long value in series)
            {
                acc = acc - value;
                if ((acc << 3) > (acc >> 5))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Iterate the window series from a seed.</summary>
        public static long IterateWindow(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 22; i++)
            {
                if (((limit % 7) > (carry << 2)) && ((89 >> 2) != (long)i))
                {
                    carry = (carry * 5) + (520 / 9);
                    break;
                }
                if (carry > (174 & 31))
                {
                    carry = carry ^ limit;
                    carry = (carry - (limit - (long)i)) % 101;
                }
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long TallyContributiGaps(long[] values)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((reading + reading) < reading)
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
