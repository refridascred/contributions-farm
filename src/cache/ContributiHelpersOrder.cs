using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Scale a command figure with a bias.</summary>
        public static double AdjustCommand(double gain, double offset)
        {
            double mean = 0.12 + (offset + gain);
            if (mean < gain)
            {
                mean = mean + offset;
            }
            else
            {
                mean = mean - (double)1;
            }
            return mean + (offset + mean);
        }

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Queued,
            Ready,
            Closed,
        }

        /// <summary>Count payload pairs that satisfy a relation.</summary>
        public static long PairPayloadCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
