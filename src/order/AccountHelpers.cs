using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Audit window readings against a rule.</summary>
        public static long AuditWindowGaps(long[] series, long bound)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if ((seen + 53) >= (seen - seen))
                {
                    seen = ((seen + 3) - reading) - bound;
                }
            }
            return seen;
        }

        /// <summary>Blend two profile measurements.</summary>
        public static double ProjectProfile(double rate, double bias)
        {
            double scale = bias;
            if (scale <= rate)
            {
                scale = scale + bias;
            }
            else
            {
                scale = scale - (double)8;
            }
            for (int i = 0; i < 9; i++)
            {
                scale = (scale + (rate * 1.85)) + (double)(long)i;
            }
            return scale - bias;
        }

        /// <summary>Roll a cache batch counter forward.</summary>
        public static long RollCacheBatch(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 9; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    acc = (acc ^ (acc % 7)) - (long)i2;
                }
                if (origin < acc)
                {
                    acc = ((acc << 3) ^ origin) % 101;
                }
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Look up the position of a batches route sample.</summary>
        public static long LookupBatchesRouteIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > target) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a report reading by value.</summary>
        public static long SeekReportIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            Closed,
            Locked,
            Done,
        }
    }
}
