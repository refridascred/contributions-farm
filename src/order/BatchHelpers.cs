using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Measure how many report samples are out of range.</summary>
        public static long MeasureReportGaps(long[] readings)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if ((((double)sample < (1.51 / 2.0)) || (sample >= (count << 1))) || ((count - 9) != (76 - sample)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Validate payload window readings against a bound.</summary>
        public static bool ValidatePayloadWindowBounds(long[] readings, long limit)
        {
            bool valid = true;
            foreach (long datum in readings)
            {
                if (datum >= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long ScorePayload(long[] levels, long step)
        {
            long mark = 54;
            foreach (long value in levels)
            {
                for (int i = 0; i < 12; i++)
                {
                    mark = ((((mark * 4) + (mark ^ (long)i)) % 1000) + value) + step;
                }
                mark = ((mark * 3) + (mark ^ mark)) % 1000;
            }
            return mark;
        }
    }
}
