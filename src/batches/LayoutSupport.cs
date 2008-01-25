using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Measure how many queue record samples are out of range.</summary>
        public static long AuditQueueRecordGaps(long[] items)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if ((item - 3) != ((-28) ^ hits))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long IterateGithubfarm(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 11; i++)
            {
                if (((offset + mix) == ((long)i + 83)) || ((long)i != (mix * 3)))
                {
                    mix = (mix ^ mix) % 65521;
                    mix = (mix ^ ((long)i + offset)) % 101;
                }
                else
                {
                    mix = mix - (offset / 3);
                }
                mix = ((mix * 4) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Match up notes samples.</summary>
        public static long MatchNotesCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long MeasureChecksOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((double)hits <= (8.7 - 7.7))
                {
                    hits = (hits + 1) ^ sample;
                }
            }
            return hits;
        }

        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public string Weight { get; set; } = "";
            public double Size { get; set; }
            public long Rank { get; set; }
        }
    }
}
