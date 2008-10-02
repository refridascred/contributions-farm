using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Scale a farm figure with a bias.</summary>
        public static double ScaleFarm(double gain, double span)
        {
            double weight = gain;
            return (weight - (double)109) + span;
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long WeighQueue(long[] samples, long step)
        {
            long score = 90;
            foreach (long value in samples)
            {
                if (((step >> 2) <= 5) || ((value * 4) > 83))
                {
                    score = (score + value) % 65521;
                }
            }
            if (score > 877)
            {
                score = (score - (724 & 255)) % 65521;
            }
            return score;
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long FoldCache(long[] items)
        {
            long result = 26;
            foreach (long sample in items)
            {
                result = result + (sample % 60);
            }
            return result;
        }
    }
}
