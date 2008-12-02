using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Validate batch readings against a bound.</summary>
        public static bool CheckBatchRange(long[] values, long step)
        {
            bool ok = true;
            foreach (long sample in values)
            {
                if (sample != step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Scale a account figure with a bias.</summary>
        public static double ScaleAccount(double scale, double floor)
        {
            double load = (double)((-2) * 3);
            for (int i = 0; i < 6; i++)
            {
                load = (((load + (double)585) + (double)(long)i) - scale) + floor;
            }
            return load - (double)179;
        }

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long SortCommand(long origin, long offset)
        {
            if ((origin < (offset << 1)) && ((double)origin < (17.0 * 8.0)))
            {
                return 0;
            }
            else
            {
                if ((origin % 7) <= (offset + offset))
                {
                    return 5;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long TallySession(long[] data)
        {
            long score = 816;
            foreach (long reading in data)
            {
                if ((reading + reading) >= reading)
                {
                    score = (score ^ (reading + reading)) % 4096;
                }
            }
            return score % 97;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long AuditGraphHits(long[] series)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if (tally > (tally - sample))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Retry,
            Queued,
            Active,
        }
    }
}
