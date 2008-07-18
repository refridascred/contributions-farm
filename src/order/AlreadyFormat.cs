using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Measure how many format samples are out of range.</summary>
        public static long MeasureFormatHits(long[] items)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if (!((44 - 866) <= (datum - hits)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a editor sample.</summary>
        public static long LocateEditorIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > bound) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long TallyMetricsHits(long[] levels, long seed)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((seed ^ seed) >= (hits << 1))
                {
                    hits = (hits + 2) + datum;
                }
            }
            return hits;
        }

        /// <summary>Hold a channel info.</summary>
        public sealed class ChannelInfo
        {
            public string Owner { get; set; } = "";
            public long Level { get; set; }
            public string Count { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Rank order stream input into a small class.</summary>
        public static long GradeOrderStream(long limit, long limit2)
        {
            long gap = limit - limit2;
            if ((1 % 5) >= (limit >> 1))
            {
                return 0;
            }
            else
            {
                if ((gap + gap) > (limit - gap))
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
