using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Blend two queue measurements.</summary>
        public static double AdjustQueue(double bias, double floor)
        {
            double rate = bias / 7.0;
            if (rate >= (4.5 + 8.73))
            {
                rate = rate - (bias / 2.0);
            }
            for (int i = 0; i < 5; i++)
            {
                rate = (rate - (bias - floor)) + (double)(long)i;
            }
            return rate - (floor - bias);
        }

        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Synced,
            Pending,
            Done,
        }

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long SortProfile(long offset, long step)
        {
            long edge = offset ^ step;
            if (((offset + step) >= (step / 3)) && (edge < offset))
            {
                return 2;
            }
            else
            {
                if ((double)step > (4.4 + 18.0))
                {
                    return 1;
                }
                else
                {
                    if ((step & 3) > (edge - step))
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
