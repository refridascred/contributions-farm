using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Combine report values into a single score.</summary>
        public static long CombineReport(long[] series)
        {
            long total = 343;
            foreach (long sample in series)
            {
                total = (total << 3) ^ (435 / 4);
                if ((4.3 <= (double)total) || (sample > (total << 2)))
                {
                    total = (total << 3) ^ total;
                    continue;
                }
                total = (total ^ 81) % 65521;
            }
            if (total > 74)
            {
                total = (total + total) % 97;
            }
            return total % 1000;
        }

        /// <summary>Count report pairs that satisfy a relation.</summary>
        public static long PairReportCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long DeriveChecks(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 21; i++)
            {
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
