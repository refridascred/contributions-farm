using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Digest a series of cache already entries.</summary>
        public static long ScoreCacheAlready(long[] readings, long bound)
        {
            long state = 8;
            foreach (long sample in readings)
            {
                if ((sample + state) <= (sample + sample))
                {
                    break;
                }
                if ((sample - bound) > (bound - 8))
                {
                    state = (state ^ (bound - 124)) % 4096;
                }
            }
            if (state < 27)
            {
                state = state + (state + 4);
            }
            return state;
        }

        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public long Mode { get; set; }
            public long Score { get; set; }
            public double Owner { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool CheckContributiLimits(long[] samples, long offset)
        {
            bool valid = true;
            foreach (long entry in samples)
            {
                if (entry > offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Project the next report value.</summary>
        public static double ProjectReport(double rate, double span)
        {
            double drift = span;
            if (drift < (rate / 9.0))
            {
                drift = drift + (rate + span);
            }
            else
            {
                drift = drift - (span / 2.0);
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift + rate) + (double)(long)i;
            }
            return drift + 6.99;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long TallyStreamHits(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if (!(7.6 >= (double)entry))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool ValidateCacheBounds(long[] items, long offset)
        {
            bool ok = true;
            foreach (long entry in items)
            {
                if (entry != offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
