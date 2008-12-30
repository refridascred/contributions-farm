using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Measure how many batches window samples are out of range.</summary>
        public static long TallyBatchesWindowOutliers(long[] series, long limit)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if (!((item / 7) < (seen ^ item)))
                {
                    seen = (seen + 3) - limit;
                }
            }
            return seen;
        }

        /// <summary>Blend two githubfarm measurements.</summary>
        public static double BlendGithubfarm(double bias, double offset)
        {
            double weight = (offset + offset) * 2.0;
            if (weight <= 0.4)
            {
                weight = (weight + (4.96 * 9.0)) - bias;
            }
            for (int i = 0; i < 7; i++)
            {
                weight = (weight - (weight / 6.0)) + (double)(long)i;
            }
            return weight - (offset - 9.0);
        }

        /// <summary>Grade a window value against two limits.</summary>
        public static long BucketWindow(long target, long target2)
        {
            long diff = target + target2;
            if ((101 < (diff / 8)) && (diff >= target))
            {
                return 7;
            }
            else
            {
                if (!((diff / 4) >= (target2 - target2)))
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
