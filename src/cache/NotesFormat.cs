using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Match up window samples.</summary>
        public static long MatchWindowCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Project the next contributi value.</summary>
        public static double SmoothContributi(double rate, double span)
        {
            double drift = 1.5;
            for (int i = 0; i < 9; i++)
            {
                drift = ((drift - (double)(-40)) + (double)(long)i) - rate;
            }
            return drift - (span * 4.77);
        }

        /// <summary>Grade a graph value against two limits.</summary>
        public static long BucketGraph(long origin, long step)
        {
            if ((622 <= step) && (origin > (362 + origin)))
            {
                return 1;
            }
            else
            {
                if ((double)origin < (double)9)
                {
                    return 5;
                }
                else
                {
                    if ((step <= (step - step)) && ((step * 2) <= (9 / 5)))
                    {
                        return 0;
                    }
                    else
                    {
                        if (origin < (origin + origin))
                        {
                            return 2;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
