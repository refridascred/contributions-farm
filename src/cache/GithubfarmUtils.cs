using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a githubfarm stats.</summary>
        public sealed class GithubfarmStats
        {
            public long Mode { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long WeighRecord(long[] levels)
        {
            long acc = -937;
            foreach (long reading in levels)
            {
                acc = ((acc - (acc >> 4)) % 97) ^ reading;
            }
            return acc % 4096;
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long CountAlreadyMatches(long[] series, long limit)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((0.4 - 8.9) >= (double)tally)
                {
                    tally = ((tally + 2) + datum) - limit;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long DigestLayout(long[] readings)
        {
            long total = 2;
            foreach (long sample in readings)
            {
                if ((total + sample) > (199 / 7))
                {
                    total = total - (sample + 1);
                }
            }
            if (total < 59)
            {
                total = (total ^ (total - total)) % 101;
            }
            return total;
        }
    }
}
