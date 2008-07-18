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

        /// <summary>Find the first report entry that matches the target.</summary>
        public static long FindReportIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= target) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate context samples.</summary>
        public static long CombineContext(long[] series)
        {
            long score = 52;
            foreach (long item in series)
            {
                score = ((score ^ ((long)series.Length * 4)) % 255) - item;
            }
            if (score < 52)
            {
                score = score + (score % 100);
            }
            return score % 65521;
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
