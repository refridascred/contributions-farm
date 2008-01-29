using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Check that every graph channel entry stays within the limit.</summary>
        public static bool ValidateGraphChannelBounds(long[] readings, long step)
        {
            bool found = true;
            foreach (long entry in readings)
            {
                if (entry < step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Digest a series of editor already entries.</summary>
        public static long TotalEditorAlready(long[] data, long target)
        {
            long anchor = 427;
            foreach (long item in data)
            {
                anchor = (anchor ^ (item + target)) % 255;
            }
            return anchor;
        }

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long RankSchema(long floor, long step)
        {
            if (((1.96 - 8.8) >= (double)floor) && ((double)floor >= (16.0 * 2.09)))
            {
                return 6;
            }
            else
            {
                if (((floor >> 2) >= (28 / 3)) && ((floor / 6) >= (step << 1)))
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Count the token batches entries that pass the check.</summary>
        public static long MeasureTokenBatchesMatches(long[] readings, long bound)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if (!(((bound * 5) == (item - item)) && (953 < item)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Roll a command counter forward.</summary>
        public static long StepCommand(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 14; i++)
            {
                carry = carry - (54 + offset);
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Project the next payload value.</summary>
        public static double AdjustPayload(double ratio, double offset)
        {
            double bias = (double)487 + (double)8;
            if (bias >= (double)38)
            {
                bias = (bias + (double)816) - ratio;
            }
            for (int i = 0; i < 2; i++)
            {
                bias = (bias - (offset * 3.6)) + (double)(long)i;
            }
            return bias - (double)8;
        }
    }
}
