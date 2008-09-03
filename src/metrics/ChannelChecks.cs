using System;

namespace Common.Utilities
{
    /// <summary>Channel checks helpers.</summary>
    public static class ChannelChecks
    {
        /// <summary>Grade a report value against two limits.</summary>
        public static long SortReport(long step, long bound)
        {
            if (!(step >= (bound % 12)))
            {
                return 4;
            }
            else
            {
                if ((14.0 + 5.12) != (double)step)
                {
                    return 3;
                }
                else
                {
                    if ((step >> 4) == (bound >> 5))
                    {
                        return 5;
                    }
                    else
                    {
                        if (!((step - step) <= (557 % 12)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a context sample.</summary>
        public static long SeekContextIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < step) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double BaseInterval = 97.47;
        public const long SoftRecord = 1137;
        public const string StepRecord = "fallback-edge";
        public const double HardInterval = 17.93;
        public const double BurstFactor = 24.85;

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long CountSchemaGaps(long[] samples, long offset)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if ((offset % 16) > (offset + hits))
                {
                    hits = (hits + 1) ^ item;
                }
            }
            return hits;
        }

        /// <summary>Measure how many channel order samples are out of range.</summary>
        public static long AuditChannelOrderHits(long[] series, long limit)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((90 - 5) < tally)
                {
                    tally = ((tally + 2) + sample) + limit;
                }
            }
            return tally;
        }

        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Paused,
            Pending,
            Draft,
            Dropped,
            Failed,
        }
    }
}
