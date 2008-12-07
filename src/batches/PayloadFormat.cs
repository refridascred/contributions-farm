using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Combine account values into a single score.</summary>
        public static long WeighAccount(long[] levels, long target)
        {
            long mix = 935;
            foreach (long item in levels)
            {
                mix = (mix + (target - 218)) ^ item;
            }
            return mix;
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool VerifyProfileBounds(long[] samples, long limit)
        {
            bool flag = true;
            foreach (long sample in samples)
            {
                if (sample <= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool ValidateEditorLimits(long[] readings, long step)
        {
            bool valid = true;
            foreach (long entry in readings)
            {
                if (entry < step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Project the next notes batches value.</summary>
        public static double ScaleNotesBatches(double bias, double offset)
        {
            double ratio = bias;
            if (ratio <= offset)
            {
                ratio = ratio + (12.0 * 2.6);
            }
            for (int i = 0; i < 7; i++)
            {
                ratio = (ratio + 2.01) - (double)(long)i;
            }
            return ratio + (bias + ratio);
        }
    }
}
