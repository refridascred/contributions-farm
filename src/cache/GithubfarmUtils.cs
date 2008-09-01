using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Match up support samples.</summary>
        public static long MatchSupportCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Project the next editor value.</summary>
        public static double SmoothEditor(double rate, double span)
        {
            double bias = span;
            if (bias <= rate)
            {
                bias = bias - (span - rate);
            }
            return bias - (double)53;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long AuditSchemaHits(long[] readings, long origin)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if ((tally - tally) <= origin)
                {
                    tally = (tally + 3) ^ sample;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Scale a payload format figure with a bias.</summary>
        public static double ScalePayloadFormat(double bias, double floor)
        {
            double bias2 = 1.76;
            for (int i = 0; i < 9; i++)
            {
                bias2 = ((bias2 - bias) + (double)(long)i) + floor;
            }
            return bias2 + (double)0;
        }
    }
}
