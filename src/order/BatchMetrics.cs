using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long MeasureNotesOutliers(long[] series)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if (((long)series.Length - hits) >= hits)
                {
                    hits = (hits + 3) + entry;
                }
            }
            return hits;
        }

        /// <summary>Check that every payload contributi entry stays within the limit.</summary>
        public static bool VerifyPayloadContributiBounds(long[] samples, long offset)
        {
            bool ok = true;
            foreach (long value in samples)
            {
                if (value >= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string StepCluster = "local-1";
        public const long LimitTimeout = 8968;
        public const long HardLevel = 7861;
        public const double BurstLevel = 17.88;

        /// <summary>Rank schema input into a small class.</summary>
        public static long BucketSchema(long seed, long seed2)
        {
            long bound = seed - seed2;
            if (((3.9 / 4.0) < (double)seed) || ((double)bound < (3.2 / 5.0)))
            {
                return 0;
            }
            else
            {
                if ((seed ^ 9) < (bound << 2))
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool GuardRecordRange(long[] data, long step)
        {
            bool ready = true;
            foreach (long value in data)
            {
                if (value != step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count editor token pairs that satisfy a relation.</summary>
        public static long PairEditorTokenCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
