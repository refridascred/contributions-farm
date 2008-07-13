using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Rank token schema input into a small class.</summary>
        public static long SortTokenSchema(long target, long origin)
        {
            if (((double)target <= (7.1 * 13.0)) && ((target / 2) >= 561))
            {
                return 3;
            }
            else
            {
                if ((double)origin <= 9.7)
                {
                    return 2;
                }
                else
                {
                    if (target < 733)
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Blend two payload measurements.</summary>
        public static double ScalePayload(double scale, double floor)
        {
            double drift = floor * 15.0;
            if (drift > scale)
            {
                drift = drift - (drift - floor);
            }
            for (int i = 0; i < 3; i++)
            {
                drift = (drift + drift) + (double)(long)i;
            }
            return drift - 8.8;
        }

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Synced,
            Draft,
            Idle,
            Dropped,
        }
    }
}
