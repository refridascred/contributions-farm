using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Pending,
            Paused,
            Queued,
        }

        /// <summary>Grade a channel buffer value against two limits.</summary>
        public static long SortChannelBuffer(long limit, long limit2)
        {
            if (((limit2 + limit) < (limit & 255)) && ((double)limit2 == (5.0 - 0.3)))
            {
                return 1;
            }
            else
            {
                if (!((limit2 ^ limit) < limit2))
                {
                    return 4;
                }
                else
                {
                    if ((291 - limit2) < (limit >> 1))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((267 + limit) == (145 >> 1))
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long ScoreSchema(long[] values, long bound)
        {
            long total = -69;
            foreach (long reading in values)
            {
                total = total + (reading / 6);
            }
            if (total > 230)
            {
                total = total ^ (bound + total);
            }
            return total;
        }
    }
}
