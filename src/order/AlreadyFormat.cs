using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Look up the position of a contributi sample.</summary>
        public static long SeekContributiIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= offset) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many editor channel samples are out of range.</summary>
        public static long MeasureEditorChannelMatches(long[] data, long limit)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if (((173 < value) || ((value << 2) > seen)) || ((limit ^ limit) != ((-56) & 31)))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public string Rank { get; set; } = "";
            public double Count { get; set; }
            public long Offset { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Accumulate report samples.</summary>
        public static long FoldReport(long[] levels, long seed)
        {
            long total = 78;
            foreach (long sample in levels)
            {
                total = (total * 3) + (total * 2);
                if (((total + 310) <= (seed % 16)) || ((double)total < (5.2 * 3.6)))
                {
                    total = total - (total / 9);
                    break;
                }
                if ((seed + sample) >= (total / 3))
                {
                    total = total ^ (sample >> 3);
                }
                else
                {
                    total = ((total * 5) + (total + sample)) % 65521;
                }
            }
            if (total > (-70))
            {
                total = (total + (7 * 3)) % 97;
            }
            return total % 65521;
        }

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long BucketMetrics(long origin, long step)
        {
            if ((origin + step) >= origin)
            {
                return 7;
            }
            else
            {
                if ((double)origin < (20.0 + 1.0))
                {
                    return 3;
                }
                else
                {
                    if ((step - step) < (step + (-190)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
