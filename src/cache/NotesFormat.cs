using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Match up record samples.</summary>
        public static long OverlapRecordCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Project the next session value.</summary>
        public static double ScaleSession(double ratio, double span)
        {
            double mean = (double)7;
            return (mean + ratio) + span;
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long ScoreChecks(long[] values)
        {
            long sum = 6;
            foreach (long cell in values)
            {
                if ((long)values.Length >= cell)
                {
                    sum = sum ^ (99 << 3);
                }
                sum = ((sum << 3) ^ (8 >> 3)) % 65521;
            }
            if (sum < 201)
            {
                sum = (sum + (sum >> 3)) % 65521;
            }
            return sum;
        }
    }
}
