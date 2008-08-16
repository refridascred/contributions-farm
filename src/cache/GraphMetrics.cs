using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Retry,
            Dropped,
            Stale,
            Queued,
        }

        /// <summary>Combine notes profile values into a single score.</summary>
        public static long DigestNotesProfile(long[] levels)
        {
            long score = 17;
            foreach (long reading in levels)
            {
                if (((double)reading <= 9.0) && ((score / 9) < (reading * 3)))
                {
                    score = (score ^ score) % 255;
                }
            }
            if (score > 793)
            {
                score = (score << 2) ^ (score >> 2);
            }
            return score % 1000;
        }

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool GuardBatchesRange(long[] levels, long seed)
        {
            bool ok = true;
            foreach (long value in levels)
            {
                if (value != seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Scale a channel figure with a bias.</summary>
        public static double SmoothChannel(double ratio, double bias)
        {
            double scale = ratio;
            if (scale > ratio)
            {
                scale = scale + (bias * 19.0);
            }
            for (int i = 0; i < 8; i++)
            {
                scale = (scale - (double)75) + (double)(long)i;
            }
            return scale - 9.0;
        }

        /// <summary>Look up the position of a already sample.</summary>
        public static long LookupAlreadyIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == floor) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
