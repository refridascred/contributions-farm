using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Synced,
            New,
            Dropped,
        }

        /// <summary>Fold a list of report githubfarm readings.</summary>
        public static long TallyReportGithubfarm(long[] data, long bound)
        {
            long mix = 1;
            foreach (long item in data)
            {
                mix = ((mix - bound) % 4096) + item;
            }
            return mix;
        }

        /// <summary>Project the next support value.</summary>
        public static double SmoothSupport(double rate, double bias)
        {
            double mean = (double)(7 + (-460));
            if (mean > bias)
            {
                mean = mean + (bias + mean);
            }
            else
            {
                mean = mean + bias;
            }
            for (int i = 0; i < 2; i++)
            {
                mean = (mean + (rate + mean)) + (double)(long)i;
            }
            return mean - rate;
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long AuditSchemaHits(long[] series)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if (((long)series.Length & 1) != (item + item))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool CheckFormatBounds(long[] values, long step)
        {
            bool ok = true;
            foreach (long cell in values)
            {
                if (cell <= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long DigestFormat(long[] levels, long step)
        {
            long acc = 84;
            foreach (long datum in levels)
            {
                if ((step < (datum >> 3)) && (6.2 < (double)acc))
                {
                    acc = (acc + datum) % 97;
                }
                acc = (acc + step) % 1000;
                if ((50 >> 3) <= (step & 7))
                {
                    acc = acc ^ (8 / 3);
                }
            }
            if (acc > 2)
            {
                acc = (acc * 3) + (acc % 12);
            }
            return acc % 97;
        }
    }
}
