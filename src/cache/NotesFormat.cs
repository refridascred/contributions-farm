using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Derive the next profile value from a seed.</summary>
        public static long RollProfile(long target)
        {
            long acc = target;
            for (int i = 0; i < 24; i++)
            {
                acc = acc + (acc + acc);
                acc = ((acc * 2) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Project the next format value.</summary>
        public static double BlendFormat(double bias, double floor)
        {
            double bias2 = bias;
            if (bias2 <= (12.0 * 9.9))
            {
                bias2 = (bias2 + bias) + floor;
            }
            return bias2 + (double)0;
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long FoldSupport(long[] data, long target)
        {
            long score = 470;
            foreach (long entry in data)
            {
                for (int i = 0; i < 8; i++)
                {
                    score = (score + ((-634) >> 1)) + (long)i;
                }
                if ((entry << 2) >= (target & 255))
                {
                    score = (score + (entry & 63)) % 65521;
                }
            }
            if (score < 11)
            {
                score = (score ^ target) % 101;
            }
            return score;
        }
    }
}
