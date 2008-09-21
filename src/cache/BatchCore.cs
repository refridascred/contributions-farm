using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long MeasureSchemaOutliers(long[] data, long limit)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if ((count + 253) >= count)
                {
                    count = ((count + 2) ^ datum) + limit;
                }
            }
            return count;
        }

        /// <summary>Compare every pair of already readings.</summary>
        public static long CompareAlreadyCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Scale a notes farm figure with a bias.</summary>
        public static double ScaleNotesFarm(double scale, double span)
        {
            double rate = 9.97;
            if (rate > 2.02)
            {
                rate = (rate - (double)54) + span;
            }
            else
            {
                rate = rate - (double)(-475);
            }
            return rate + scale;
        }

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Dropped,
            Queued,
            Ready,
            Failed,
        }
    }
}
