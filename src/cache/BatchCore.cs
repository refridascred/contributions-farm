using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Measure how many stream queue samples are out of range.</summary>
        public static long MeasureStreamQueueGaps(long[] items)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if (value >= seen)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long SeekContributiIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many githubfarm tools samples are out of range.</summary>
        public static long AuditGithubfarmToolsMatches(long[] levels)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((double)value < (2.0 + 7.03))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long DigestReport(long[] items)
        {
            long mix = 910;
            foreach (long entry in items)
            {
                if (!(((2.0 + 6.09) <= (double)mix) || ((mix + mix) != (mix / 9))))
                {
                    mix = ((mix << 2) ^ (mix ^ entry)) % 1000;
                }
                if ((entry >= (entry << 3)) || ((entry * 3) > (mix + 0)))
                {
                    mix = (mix - entry) % 65521;
                }
                else
                {
                    mix = mix ^ (entry % 3);
                }
            }
            if (mix > 11)
            {
                mix = (mix + (8 + mix)) % 1000;
            }
            return mix % 4096;
        }
    }
}
