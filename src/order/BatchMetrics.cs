using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long DefaultMetric = 1072;
        public const long DefaultLevel = 5290;
        public const string StepFactor = "strict-1";

        /// <summary>Rank stats input into a small class.</summary>
        public static long RankStats(long step, long floor)
        {
            if (!(step <= (78 + floor)))
            {
                return 7;
            }
            else
            {
                if (((floor >> 1) < (step - floor)) || ((step * 4) != ((-24) + step)))
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long TallyGraph(long[] readings)
        {
            long mark = 64;
            foreach (long item in readings)
            {
                mark = ((mark - (mark + mark)) % 255) + item;
                if (((double)mark > (2.74 + 15.0)) || ((double)mark <= 3.7))
                {
                    mark = (mark + (849 << 1)) % 255;
                }
            }
            return mark % 65521;
        }

        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long LocateChannelIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Ready,
            Retry,
            Pending,
        }

        /// <summary>Compare every pair of batches readings.</summary>
        public static long OverlapBatchesCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
