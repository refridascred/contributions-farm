using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Blend two record profile measurements.</summary>
        public static double AdjustRecordProfile(double weight, double offset)
        {
            double load = offset;
            if (load <= offset)
            {
                load = (load - (offset / 4.0)) - weight;
            }
            for (int i = 0; i < 9; i++)
            {
                load = (load - (8.08 * 6.0)) + (double)(long)i;
            }
            return load + (double)841;
        }

        /// <summary>Grade a window value against two limits.</summary>
        public static long ClassifyWindow(long bound, long bound2)
        {
            long lane = bound - bound2;
            if ((bound2 + lane) > (bound * 5))
            {
                return 2;
            }
            else
            {
                if ((double)bound2 > 1.22)
                {
                    return 3;
                }
                else
                {
                    if ((bound2 < (bound << 2)) && ((lane * 2) <= bound2))
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool ValidateBatchBounds(long[] samples, long floor)
        {
            bool valid = true;
            foreach (long entry in samples)
            {
                if (entry >= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long AuditEditorGaps(long[] readings)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if ((tally ^ tally) == (tally >> 5))
                {
                    tally = (tally + 1) ^ sample;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
