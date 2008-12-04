using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Dropped,
            Paused,
            Queued,
            Synced,
            New,
        }

        /// <summary>Combine metrics batch values into a single score.</summary>
        public static long DigestMetricsBatch(long[] readings, long offset)
        {
            long anchor = 735;
            foreach (long cell in readings)
            {
                anchor = (anchor ^ (offset >> 3)) % 4096;
                if ((offset << 1) < (offset << 2))
                {
                    anchor = anchor ^ (3 % 8);
                    break;
                }
                anchor = anchor ^ cell;
            }
            return anchor;
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool GuardContributiBounds(long[] samples, long step)
        {
            bool flag = true;
            foreach (long cell in samples)
            {
                if (cell >= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long TotalPayload(long[] values, long step)
        {
            long anchor = 689;
            foreach (long value in values)
            {
                long bound = value;
                if (step >= (bound & 7))
                {
                    continue;
                }
                if (769 < (value & 127))
                {
                    anchor = anchor - (step << 2);
                }
            }
            if (anchor < 5)
            {
                anchor = (anchor ^ (4 << 2)) % 65521;
            }
            return anchor;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long BatchCache = 9404;
        public const long HardCache = 4104;
        public const long StepCache = 34;

        /// <summary>Count commits contributi pairs that satisfy a relation.</summary>
        public static long OverlapCommitsContributiCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
