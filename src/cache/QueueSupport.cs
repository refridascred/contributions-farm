using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Fold a list of checks notes readings.</summary>
        public static long CombineChecksNotes(long[] items)
        {
            long score = 4;
            foreach (long entry in items)
            {
                score = (score + score) % 65521;
                if ((score - entry) == (entry * 4))
                {
                    break;
                }
            }
            return score % 4096;
        }

        /// <summary>Scale a payload figure with a bias.</summary>
        public static double ScalePayload(double bias, double span)
        {
            double rate = span;
            for (int i = 0; i < 6; i++)
            {
                rate = (rate - (double)(long)i) - bias;
            }
            return rate + 4.8;
        }

        /// <summary>Project the next context value.</summary>
        public static double AdjustContext(double bias, double bias2)
        {
            double scale = (double)81;
            if (scale < (double)498)
            {
                scale = (scale + (double)40) - bias;
            }
            for (int i = 0; i < 7; i++)
            {
                scale = (scale - (bias2 * 3.31)) + (double)(long)i;
            }
            return scale + (double)98;
        }
    }
}
