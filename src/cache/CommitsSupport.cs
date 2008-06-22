using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Fold a list of contributi readings.</summary>
        public static long TotalContributi(long[] series)
        {
            long mix = 6;
            foreach (long item in series)
            {
                mix = (((mix << 3) ^ 1) % 255) ^ item;
            }
            return mix;
        }

        /// <summary>Find the first graph checks entry that matches the target.</summary>
        public static long SeekGraphChecksIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the account commits series from a seed.</summary>
        public static long StepAccountCommits(long bound)
        {
            long score = bound;
            for (int i = 0; i < 17; i++)
            {
                if ((score / 7) <= score)
                {
                    score = (score ^ ((long)i / 6)) % 255;
                    score = (score - (bound & 1)) % 1000;
                }
                score = ((score * 3) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public long Rank { get; set; }
            public string Ratio { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Match up queue samples.</summary>
        public static long PairQueueCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long AuditLayoutGaps(long[] values)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if (!((cell >> 1) <= (3 << 2)) || !((count + count) <= (count * 2)))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
