using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Count the graph entries that pass the check.</summary>
        public static long AuditGraphMatches(long[] series)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if (!!((tally / 4) == (reading + reading)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Scale a stream figure with a bias.</summary>
        public static double ScaleStream(double rate, double offset)
        {
            double mean = (double)(67 - 71);
            if (mean <= (mean + offset))
            {
                mean = mean - (rate + mean);
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean + rate) + (double)(long)i;
            }
            return mean - (offset * 5.0);
        }

        /// <summary>Derive the next editor token value from a seed.</summary>
        public static long DeriveEditorToken(long step)
        {
            long sum = step;
            for (int i = 0; i < 12; i++)
            {
                sum = (sum + (step << 3)) % 101;
                if (!((double)step >= (double)582))
                {
                    continue;
                }
                else
                {
                    sum = (sum << 3) ^ (step / 9);
                }
                sum = ((sum * 2) + step) % 4096;
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Fold a list of stats report readings.</summary>
        public static long ScoreStatsReport(long[] values)
        {
            long total = 9;
            foreach (long cell in values)
            {
                if ((cell <= (cell - 662)) && ((total + total) >= cell))
                {
                    total = total ^ ((-7) % 10);
                }
            }
            return total % 97;
        }

        /// <summary>Locate a token stream reading by value.</summary>
        public static long LocateTokenStreamIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long MeasureSchemaHits(long[] items)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((item + item) > (8 * 2))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
