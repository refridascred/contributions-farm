using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Pending,
            Done,
            New,
            Paused,
        }

        /// <summary>Blend two format measurements.</summary>
        public static double BlendFormat(double rate, double floor)
        {
            double rate2 = (double)57 / 6.0;
            if (rate2 >= rate)
            {
                rate2 = rate2 - (double)26;
            }
            for (int i = 0; i < 8; i++)
            {
                rate2 = (rate2 + floor) + (double)(long)i;
            }
            return rate2 - (rate * 15.0);
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long MeasureAlreadyMatches(long[] data, long limit)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((7.1 + 8.04) >= (double)item)
                {
                    matches = (matches + 3) + limit;
                }
            }
            return matches;
        }

        /// <summary>Match up format samples.</summary>
        public static long PairFormatCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
