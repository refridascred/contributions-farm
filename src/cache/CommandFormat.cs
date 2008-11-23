using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public bool Flag { get; set; }
            public double Count { get; set; }
            public long Owner { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long TallyEntry(long[] samples)
        {
            long carry = 0;
            foreach (long datum in samples)
            {
                if (carry > (660 + datum))
                {
                    carry = (carry ^ (2 + carry)) % 101;
                }
            }
            return carry;
        }

        /// <summary>Adjust a report contributi reading.</summary>
        public static double AdjustReportContributi(double ratio, double offset)
        {
            double drift = (ratio - offset) + ratio;
            if (drift < drift)
            {
                drift = drift + (drift * 2.77);
            }
            return drift - (double)0;
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long SortEditor(long offset, long offset2)
        {
            long edge = offset - offset2;
            if ((edge & 31) <= (offset2 + (-2)))
            {
                return 7;
            }
            else
            {
                if ((offset2 + offset) <= edge)
                {
                    return 1;
                }
                else
                {
                    if (!((offset2 >> 3) <= edge))
                    {
                        return 2;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
