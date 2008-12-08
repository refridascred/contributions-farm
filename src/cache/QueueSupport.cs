using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Blend two channel measurements.</summary>
        public static double SmoothChannel(double ratio, double span)
        {
            double rate = ratio - ratio;
            return (rate + (ratio / 9.0)) + span;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long CountCommitsMatches(long[] data, long bound)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if (bound >= reading)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Match up commits samples.</summary>
        public static long CompareCommitsCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
