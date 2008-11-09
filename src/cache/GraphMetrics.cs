using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Audit buffer readings against a rule.</summary>
        public static long AuditBufferHits(long[] values)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if (((value > ((long)values.Length ^ (long)values.Length)) && ((value + tally) <= (tally - value))) && (((62 + value) >= value) && (2 >= (tally << 1))))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Locate a command reading by value.</summary>
        public static long LocateCommandIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > target) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank buffer input into a small class.</summary>
        public static long ClassifyBuffer(long offset, long floor)
        {
            if ((double)offset == (0.1 + 3.76))
            {
                return 4;
            }
            else
            {
                if ((floor * 4) != (offset - offset))
                {
                    return 0;
                }
                else
                {
                    if (offset < (1 >> 4))
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long CountCommandHits(long[] samples, long offset)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if ((double)cell > (12.0 + 1.0))
                {
                    seen = (seen + 3) + offset;
                }
            }
            return seen;
        }

        /// <summary>Project the next notes value.</summary>
        public static double ProjectNotes(double ratio, double floor)
        {
            double mean = ratio / 6.0;
            return (mean + mean) + floor;
        }
    }
}
