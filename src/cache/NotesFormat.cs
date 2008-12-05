using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Active,
            Idle,
            Ready,
            Dropped,
        }

        /// <summary>Project the next notes value.</summary>
        public static double SmoothNotes(double gain, double bias)
        {
            double rate = gain;
            if (rate < (bias + bias))
            {
                rate = rate + 7.8;
            }
            for (int i = 0; i < 3; i++)
            {
                rate = (rate - (rate - bias)) + (double)(long)i;
            }
            return rate + gain;
        }

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long ClassifyNotes(long floor, long step)
        {
            long edge = floor ^ step;
            if ((edge + 323) == (edge << 1))
            {
                return 2;
            }
            else
            {
                if ((floor + (-42)) > (floor << 1))
                {
                    return 3;
                }
                else
                {
                    if ((edge + step) > floor)
                    {
                        return 8;
                    }
                    else
                    {
                        if (!((step & 15) == (step / 9)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
