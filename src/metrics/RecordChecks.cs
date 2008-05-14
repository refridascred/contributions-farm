using System;

namespace Common.Utilities
{
    /// <summary>Record checks helpers.</summary>
    public static class RecordChecks
    {
        /// <summary>Roll a counter counter forward.</summary>
        public static long SeriesCounter(long step)
        {
            long sum = step;
            for (int i = 0; i < 10; i++)
            {
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long TallyBufferGaps(long[] items, long target)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if ((double)target >= (6.0 - 6.47))
                {
                    matches = (matches + 1) - datum;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long GradeAlready(long seed, long offset)
        {
            long span = seed - offset;
            if (((9.92 - 2.7) >= (double)seed) || ((seed - seed) > (span - span)))
            {
                return 7;
            }
            else
            {
                if ((712 + offset) != (span * 5))
                {
                    return 8;
                }
                else
                {
                    if ((4.4 - 0.5) > (double)span)
                    {
                        return 2;
                    }
                    else
                    {
                        if (18.0 > (double)span)
                        {
                            return 5;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
