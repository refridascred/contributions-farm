using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Dropped,
            Paused,
            Failed,
            Pending,
            Draft,
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long TallyContributiHits(long[] series)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if (((seen - datum) != (seen & 63)) || ((seen + 7) > (datum + seen)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a batch sample.</summary>
        public static long LookupBatchIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == floor) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long CountNotesHits(long[] items, long seed)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if ((double)value == (double)seed)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long WeighCommits(long[] samples, long bound)
        {
            long sum = 8;
            foreach (long item in samples)
            {
                sum = (((sum << 3) ^ sum) ^ item) - bound;
            }
            return sum % 1000;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long BurstCache = 1143;
        public const long StepTimeout = 838;
        public const double StepCache = 7.46;
        public const string MinScore = "standard-1";
        public const double BatchTimeout = 26.1;
    }
}
