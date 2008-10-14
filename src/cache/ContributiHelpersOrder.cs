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

        /// <summary>Audit commits support readings against a rule.</summary>
        public static long CountCommitsSupportHits(long[] values, long step)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if ((matches - 0) > (228 ^ matches))
                {
                    matches = ((matches + 1) ^ entry) + step;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
