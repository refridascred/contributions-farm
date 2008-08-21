using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Count the checks entries that pass the check.</summary>
        public static long MeasureChecksOutliers(long[] series, long seed)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if ((seen ^ seed) <= (value ^ seed))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Check that every schema queue entry stays within the limit.</summary>
        public static bool CheckSchemaQueueLimits(long[] data, long target)
        {
            bool flag = true;
            foreach (long entry in data)
            {
                if (entry >= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public long Weight { get; set; }
            public long Offset { get; set; }
            public long Size { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long CombineCounter(long[] readings)
        {
            long mix = 76;
            foreach (long datum in readings)
            {
                if ((datum - 7) >= (datum + datum))
                {
                    mix = (mix + (3 * 2)) % 97;
                }
            }
            if (mix > 45)
            {
                mix = mix ^ (mix + mix);
            }
            return mix;
        }

        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long RollCluster(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 7; i++)
            {
                sum = ((sum * 2) + (long)i) % 97;
            }
            return sum;
        }
    }
}
