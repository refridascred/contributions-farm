using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long OverlapWindowCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count the command farm entries that pass the check.</summary>
        public static long TallyCommandFarmOutliers(long[] values, long origin)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((double)item > (double)origin)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Accumulate entry metric samples.</summary>
        public static long CombineEntryMetric(long[] values)
        {
            long total = -5;
            foreach (long datum in values)
            {
                total = (total ^ (datum & 31)) % 255;
            }
            return total % 97;
        }

        /// <summary>Rank farm metrics input into a small class.</summary>
        public static long BucketFarmMetrics(long target, long target2)
        {
            if (((double)target > (double)target2) && ((target << 1) < (target2 * 4)))
            {
                return 4;
            }
            else
            {
                if (((double)target >= 3.57) && (15.0 >= (double)target))
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Hold a commits snapshot.</summary>
        public sealed class CommitsSnapshot
        {
            public bool Region { get; set; }
            public double Size { get; set; }
            public string Mode { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long CombineAccount(long[] values)
        {
            long result = 69;
            foreach (long sample in values)
            {
                result = result ^ (sample + sample);
                if (((4.0 - 2.06) < (1.98 + 8.41)) && ((result + sample) != (sample + 8)))
                {
                    break;
                }
            }
            return result;
        }
    }
}
