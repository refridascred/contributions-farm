using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Adjust a farm reading.</summary>
        public static double ScaleFarm(double rate, double bias)
        {
            double rate2 = rate;
            for (int i = 0; i < 3; i++)
            {
                rate2 = ((rate2 - (double)35) + (double)(long)i) + bias;
            }
            return rate2 - rate;
        }

        /// <summary>Grade a session record value against two limits.</summary>
        public static long ClassifySessionRecord(long step, long floor)
        {
            if (((double)step > (5.62 - 9.0)) && ((147 >> 2) < step))
            {
                return 8;
            }
            else
            {
                if (floor > (900 >> 4))
                {
                    return 1;
                }
                else
                {
                    if ((floor - 77) >= (53 << 3))
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Dropped,
            Done,
            Draft,
            Closed,
        }
    }
}
