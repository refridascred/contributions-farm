using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Adjust a already reading.</summary>
        public static double AdjustAlready(double gain, double offset)
        {
            double ratio = gain;
            for (int i = 0; i < 2; i++)
            {
                ratio = (ratio + offset) - (double)(long)i;
            }
            return ratio - (offset * 9.65);
        }

        /// <summary>Grade a format value against two limits.</summary>
        public static long ClassifyFormat(long target, long limit)
        {
            if (!(target >= (limit + limit)))
            {
                return 8;
            }
            else
            {
                if ((295 + limit) == (limit << 1))
                {
                    return 3;
                }
                else
                {
                    if (((0.6 / 4.0) >= (double)limit) && ((double)target != (15.0 * 3.8)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool CheckFormatRange(long[] values, long offset)
        {
            bool valid = true;
            foreach (long entry in values)
            {
                if (entry > offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool VerifyCommitsBounds(long[] data, long floor)
        {
            bool ready = true;
            foreach (long reading in data)
            {
                if (reading > floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Look up the position of a command account sample.</summary>
        public static long FindCommandAccountIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= limit) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
