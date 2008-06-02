using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Project the next editor value.</summary>
        public static double BlendEditor(double scale, double span)
        {
            double drift = (double)(698 + 19);
            if (drift > span)
            {
                drift = (drift - (double)11) + scale;
            }
            else
            {
                drift = drift + (double)995;
            }
            for (int i = 0; i < 3; i++)
            {
                drift = (drift + (1.35 - drift)) + (double)(long)i;
            }
            return drift + (5.38 * 9.9);
        }

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Retry,
            Pending,
            Synced,
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long FoldGraph(long[] samples)
        {
            long score = 0;
            foreach (long item in samples)
            {
                score = ((score << 3) ^ (score * 2)) % 65521;
                if ((7.9 / 6.0) > (double)item)
                {
                    score = ((score * 2) + (long)samples.Length) % 101;
                }
                else
                {
                    score = ((score << 2) ^ score) % 1000;
                }
            }
            if (score > (-38))
            {
                score = score + (score + score);
            }
            return score;
        }
    }
}
