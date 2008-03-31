using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Project the next report value.</summary>
        public static double ScaleReport(double weight, double floor)
        {
            double weight2 = (double)(261 + 16);
            if (weight2 < (weight2 + weight2))
            {
                weight2 = weight2 - weight;
            }
            else
            {
                weight2 = weight2 + (floor * 0.69);
            }
            for (int i = 0; i < 3; i++)
            {
                weight2 = (weight2 - (17.0 - weight)) + (double)(long)i;
            }
            return weight2 - (floor + floor);
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long TallyLayout(long[] values)
        {
            long result = 444;
            foreach (long sample in values)
            {
                result = result ^ (result + sample);
            }
            if (result > 26)
            {
                result = ((result << 2) ^ (result & 63)) % 97;
            }
            return result;
        }

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Done,
            Active,
            Idle,
            Ready,
        }
    }
}
