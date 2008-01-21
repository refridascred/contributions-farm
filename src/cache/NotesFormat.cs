using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Compare every pair of report readings.</summary>
        public static long MatchReportCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Rank queue input into a small class.</summary>
        public static long GradeQueue(long bound, long limit)
        {
            if (limit > (limit - bound))
            {
                return 0;
            }
            else
            {
                if (!((double)limit >= 6.4))
                {
                    return 6;
                }
                else
                {
                    if ((limit + limit) < (-46))
                    {
                        return 5;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Adjust a session reading.</summary>
        public static double SmoothSession(double gain, double bias)
        {
            double rate = (5.0 / 7.0) * 12.0;
            return (rate + gain) + bias;
        }
    }
}
