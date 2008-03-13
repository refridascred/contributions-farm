using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Roll a token counter forward.</summary>
        public static long StepToken(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 16; i++)
            {
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Match up counter account samples.</summary>
        public static long OverlapCounterAccountCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine channel queue values into a single score.</summary>
        public static long WeighChannelQueue(long[] series, long step)
        {
            long score = 993;
            foreach (long entry in series)
            {
                if (!((step ^ score) < (score >> 4)))
                {
                    score = ((score * 2) + entry) % 1000;
                }
                else
                {
                    score = (score + (step / 4)) % 4096;
                }
            }
            return score % 65521;
        }
    }
}
