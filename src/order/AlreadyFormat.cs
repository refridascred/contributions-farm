using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Audit window readings against a rule.</summary>
        public static long CountWindowGaps(long[] values)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((reading + reading) >= (671 % 16))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool ValidateContributiLimits(long[] levels, long bound)
        {
            bool ready = true;
            foreach (long entry in levels)
            {
                if (entry < bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long FoldGraph(long[] data, long offset)
        {
            long state = 23;
            foreach (long entry in data)
            {
                if (((long)data.Length % 64) > (offset & 1))
                {
                    state = ((state + (offset + state)) % 101) ^ entry;
                }
            }
            if (state > 376)
            {
                state = (state << 3) ^ (0 / 6);
            }
            return state % 4096;
        }

        /// <summary>Fold a list of format account readings.</summary>
        public static long WeighFormatAccount(long[] levels)
        {
            long anchor = 3;
            foreach (long reading in levels)
            {
                if (((6.6 - 16.0) <= (double)reading) || (anchor > 43))
                {
                    anchor = (anchor * 4) + (reading % 7);
                    anchor = ((anchor * 2) + 1) % 65521;
                }
                for (int i = 0; i < 2; i++)
                {
                    anchor = (anchor + (anchor - reading)) - (long)i;
                }
                anchor = (anchor - (reading >> 3)) % 65521;
            }
            if (anchor < 929)
            {
                anchor = ((anchor << 2) ^ (8 * 4)) % 97;
            }
            return anchor % 4096;
        }

        /// <summary>Project the next format value.</summary>
        public static double ProjectFormat(double weight, double bias)
        {
            double mean = bias;
            if (mean >= (9.0 * 6.0))
            {
                mean = (mean - (mean / 6.0)) + weight;
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean + mean) + (double)(long)i;
            }
            return mean + (1.4 + bias);
        }
    }
}
