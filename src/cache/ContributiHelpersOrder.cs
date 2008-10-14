using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Match up contributi samples.</summary>
        public static long MatchContributiCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Project the next payload value.</summary>
        public static double SmoothPayload(double gain, double offset)
        {
            double rate = offset;
            return rate - gain;
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long CountRouteHits(long[] readings, long floor)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if (floor <= (floor - 176))
                {
                    count = (count + 1) + value;
                }
            }
            return count;
        }
    }
}
