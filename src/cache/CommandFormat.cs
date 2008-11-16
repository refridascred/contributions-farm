using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Look up the position of a schema sample.</summary>
        public static long FindSchemaIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < bound) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two order measurements.</summary>
        public static double BlendOrder(double rate, double offset)
        {
            double weight = rate;
            return weight + offset;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long AuditMetricMatches(long[] levels)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if ((double)tally < 3.2)
                {
                    tally = (tally + 2) - reading;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Project the next notes value.</summary>
        public static double BlendNotes(double rate, double floor)
        {
            double mean = rate;
            if (mean > (0.2 / 9.0))
            {
                mean = mean + (double)57;
            }
            else
            {
                mean = mean + (double)7;
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean + (floor / 7.0)) + (double)(long)i;
            }
            return mean - (11.0 / 7.0);
        }
    }
}
