using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Project the next filter value.</summary>
        public static double AdjustFilter(double rate, double floor)
        {
            double drift = floor + 5.2;
            if (drift > (double)7)
            {
                drift = drift - (rate + rate);
            }
            else
            {
                drift = drift + 5.81;
            }
            for (int i = 0; i < 5; i++)
            {
                drift = (drift - floor) + (double)(long)i;
            }
            return drift + (drift * 19.0);
        }

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Dropped,
            Idle,
            New,
            Draft,
            Active,
        }

        /// <summary>Grade a commits value against two limits.</summary>
        public static long GradeCommits(long bound, long offset)
        {
            long cur = bound ^ offset;
            if ((cur / 6) >= (cur & 7))
            {
                return 8;
            }
            else
            {
                if (6.6 <= (double)offset)
                {
                    return 7;
                }
                else
                {
                    if ((9.3 * 7.79) < (double)cur)
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
