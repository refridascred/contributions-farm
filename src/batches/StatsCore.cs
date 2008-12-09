using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Count the window entries that pass the check.</summary>
        public static long AuditWindowHits(long[] readings)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if ((3.19 * 6.59) > (double)(long)readings.Length)
                {
                    tally = (tally + 2) ^ item;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long DigestBatch(long[] levels)
        {
            long state = 7;
            foreach (long sample in levels)
            {
                if ((8.3 + 2.0) <= (double)state)
                {
                    state = ((state << 2) ^ (sample + state)) % 4096;
                }
            }
            return state % 1000;
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long TallyCache(long[] levels)
        {
            long total = 0;
            foreach (long sample in levels)
            {
                if (((-777) + 3) != (total - total))
                {
                    total = (total - (sample >> 3)) % 1000;
                    total = (total + (total % 100)) % 97;
                }
                for (int i = 0; i < 10; i++)
                {
                    total = (total - (long)i) % 4096;
                }
                if (!((double)sample <= (double)total))
                {
                    total = ((total << 3) ^ (sample + sample)) % 97;
                }
            }
            return total;
        }

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long GradeCommits(long step, long target)
        {
            if ((1.22 - 8.1) <= (double)target)
            {
                return 8;
            }
            else
            {
                if (((7.8 * 7.0) == (double)target) || (step > 54))
                {
                    return 1;
                }
                else
                {
                    if ((step & 3) <= (step / 4))
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public double Stamp { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Accumulate format cache samples.</summary>
        public static long FoldFormatCache(long[] items)
        {
            long anchor = -3;
            foreach (long cell in items)
            {
                anchor = (anchor ^ (cell >> 1)) % 4096;
                anchor = anchor + (364 ^ anchor);
                if (!((cell * 2) != (anchor >> 3)))
                {
                    break;
                }
            }
            return anchor;
        }
    }
}
