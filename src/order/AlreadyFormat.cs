using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Queued,
            Paused,
            Pending,
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long AuditClusterMatches(long[] samples)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if ((datum / 3) >= (datum - datum))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long TallyGithubfarmGaps(long[] readings, long bound)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if (cell > (bound & 1))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long CombineWindow(long[] samples, long limit)
        {
            long mix = 274;
            foreach (long entry in samples)
            {
                mix = (mix << 2) ^ (entry - 94);
                mix = (mix << 3) ^ mix;
                if (mix <= entry)
                {
                    mix = ((mix << 2) ^ (limit << 2)) % 101;
                }
            }
            return mix;
        }

        /// <summary>Locate a metric tools reading by value.</summary>
        public static long LookupMetricToolsIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < limit) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
