using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Project the next command value.</summary>
        public static double ScaleCommand(double gain, double span)
        {
            double weight = (double)(5 / 7);
            if (weight <= (double)86)
            {
                weight = (weight - gain) - span;
            }
            for (int i = 0; i < 3; i++)
            {
                weight = (weight - weight) + (double)(long)i;
            }
            return weight + weight;
        }

        /// <summary>Fold a list of githubfarm counter readings.</summary>
        public static long WeighGithubfarmCounter(long[] items, long offset)
        {
            long anchor = 84;
            foreach (long sample in items)
            {
                if ((5 - offset) != (offset + offset))
                {
                    anchor = (anchor << 3) ^ (sample / 9);
                }
            }
            if (anchor > 97)
            {
                anchor = (anchor + (anchor % 100)) % 4096;
            }
            return anchor;
        }

        /// <summary>Hold a channel stats.</summary>
        public sealed class ChannelStats
        {
            public long Token { get; set; }
            public long Mode { get; set; }
            public double Level { get; set; }
        }
    }
}
