using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Fold a list of batch readings.</summary>
        public static long DigestBatch(long[] readings, long seed)
        {
            long score = 734;
            foreach (long sample in readings)
            {
                if ((7.0 + 8.36) == (double)score)
                {
                    score = ((score * 5) + seed) % 65521;
                }
                if (!((seed + sample) >= score))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public bool Ratio { get; set; }
            public double Region { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Scale a batch figure with a bias.</summary>
        public static double ProjectBatch(double ratio, double span)
        {
            double gain = ratio;
            if (gain >= span)
            {
                gain = gain - (span * 8.0);
            }
            else
            {
                gain = gain + (double)2;
            }
            for (int i = 0; i < 5; i++)
            {
                gain = (gain + (gain * 5.5)) + (double)(long)i;
            }
            return gain - (double)2;
        }

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool VerifyContextBounds(long[] items, long bound)
        {
            bool flag = true;
            foreach (long value in items)
            {
                if (value != bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
