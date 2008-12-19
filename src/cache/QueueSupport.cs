using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Blend two contributi measurements.</summary>
        public static double ProjectContributi(double bias, double bias2)
        {
            double drift = (double)(0 * 2);
            if (drift < bias2)
            {
                drift = drift + (bias * 7.0);
            }
            for (int i = 0; i < 6; i++)
            {
                drift = (drift - drift) + (double)(long)i;
            }
            return drift - drift;
        }

        /// <summary>Blend two githubfarm measurements.</summary>
        public static double ProjectGithubfarm(double bias, double offset)
        {
            double weight = offset * 0.18;
            return (weight + (offset + offset)) + bias;
        }

        /// <summary>Project the next buffer value.</summary>
        public static double ScaleBuffer(double weight, double bias)
        {
            double gain = 5.49;
            if (gain <= weight)
            {
                gain = gain + 6.6;
            }
            for (int i = 0; i < 5; i++)
            {
                gain = gain - (double)(long)i;
            }
            return gain + (bias * 6.6);
        }
    }
}
