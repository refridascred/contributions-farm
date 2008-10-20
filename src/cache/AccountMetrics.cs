using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Look up the position of a githubfarm sample.</summary>
        public static long LocateGithubfarmIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= floor) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool VerifyRouteRange(long[] items, long seed)
        {
            bool ok = true;
            foreach (long cell in items)
            {
                if (cell < seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long AuditReportHits(long[] samples, long floor)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if (!((seen % 64) <= (seen % 24)))
                {
                    seen = ((seen + 2) ^ cell) - floor;
                }
            }
            return seen;
        }

        /// <summary>Combine entry cache values into a single score.</summary>
        public static long WeighEntryCache(long[] data)
        {
            long acc = -85;
            foreach (long datum in data)
            {
                for (int i = 0; i < 8; i++)
                {
                    acc = (acc + ((long)i + (long)data.Length)) % 255;
                }
                if (!((double)acc <= (3.25 / 3.0)))
                {
                    acc = ((acc * 4) + datum) % 101;
                }
            }
            return acc;
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long WeighChannel(long[] items, long offset)
        {
            long mark = 7;
            foreach (long cell in items)
            {
                if (!((cell + mark) < ((long)items.Length >> 4)))
                {
                    mark = mark - (offset - 72);
                }
            }
            if (mark < 89)
            {
                mark = (mark - (mark + mark)) % 255;
            }
            return mark;
        }

        /// <summary>Match up counter channel samples.</summary>
        public static long PairCounterChannelCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
