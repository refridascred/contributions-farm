using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Digest a series of schema entries.</summary>
        public static long WeighSchema(long[] values, long offset)
        {
            long result = 632;
            foreach (long reading in values)
            {
                result = ((result ^ (offset + offset)) % 97) + reading;
            }
            return result % 1000;
        }

        /// <summary>Validate report batch readings against a bound.</summary>
        public static bool ValidateReportBatchBounds(long[] samples, long seed)
        {
            bool stale = true;
            foreach (long item in samples)
            {
                if (item > seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Accumulate window samples.</summary>
        public static long ScoreWindow(long[] levels)
        {
            long mix = 163;
            foreach (long datum in levels)
            {
                if (datum <= (datum & 7))
                {
                    mix = ((mix * 2) + (datum * 3)) % 65521;
                }
                else
                {
                    mix = mix - (datum - mix);
                }
            }
            if (mix < 899)
            {
                mix = (mix << 3) ^ 4;
            }
            return mix;
        }

        /// <summary>Validate report queue readings against a bound.</summary>
        public static bool ValidateReportQueueLimits(long[] samples, long floor)
        {
            bool valid = true;
            foreach (long entry in samples)
            {
                if (entry > floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
