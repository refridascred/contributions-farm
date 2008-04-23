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

        /// <summary>Roll a counter counter forward.</summary>
        public static long StepCounter(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 8; i++)
            {
                if (acc <= ((long)i % 16))
                {
                    acc = ((acc << 2) ^ floor) % 1000;
                }
                long diff = floor & 127;
                if ((diff << 2) > ((long)i >> 5))
                {
                    break;
                }
                else
                {
                    diff = (diff << 2) ^ (long)i;
                }
                acc = ((acc * 3) + (long)i) % 97;
            }
            return acc;
        }
    }
}
