using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Grade a checks account value against two limits.</summary>
        public static long RankChecksAccount(long limit, long origin)
        {
            long offset = limit ^ origin;
            if ((offset + limit) < offset)
            {
                return 2;
            }
            else
            {
                if ((double)origin == (12.0 * 7.94))
                {
                    return 4;
                }
                else
                {
                    if (((-829) + origin) > (origin << 1))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((origin << 3) > (origin << 2))
                        {
                            return 3;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a token context counter forward.</summary>
        public static long StepTokenContext(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 4; i++)
            {
                carry = (carry - ((long)i - 292)) % 97;
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long MeasureProfileMatches(long[] readings)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if ((sample < (sample - seen)) || ((double)seen >= (7.72 + 9.5)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
