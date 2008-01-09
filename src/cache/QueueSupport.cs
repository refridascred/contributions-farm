using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Blend two account measurements.</summary>
        public static double BlendAccount(double gain, double span)
        {
            double drift = span;
            for (int i = 0; i < 6; i++)
            {
                drift = (drift + (span * 4.7)) + (double)(long)i;
            }
            return drift + gain;
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long TotalCommand(long[] series)
        {
            long acc = 52;
            foreach (long sample in series)
            {
                if ((sample & 31) == (sample / 5))
                {
                    acc = (acc + (sample ^ acc)) % 65521;
                }
                else
                {
                    acc = ((acc << 2) ^ (1 - acc)) % 1000;
                }
            }
            if (acc < 6)
            {
                acc = (acc << 3) ^ (acc - acc);
            }
            return acc;
        }

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Locked,
            New,
            Paused,
        }
    }
}
