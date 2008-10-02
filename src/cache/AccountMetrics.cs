using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long StepPayload = 5796;
        public const string LimitPayload = "alpha";
        public const long MinPayload = 8810;
        public const double MaxPayload = 8.24;
        public const double BatchBudget = 2.54;

        /// <summary>Digest a series of format session entries.</summary>
        public static long DigestFormatSession(long[] samples, long origin)
        {
            long score = 1;
            foreach (long entry in samples)
            {
                if ((7.6 - 8.27) <= (double)entry)
                {
                    score = (score - (origin << 2)) % 1000;
                    break;
                }
                if ((double)28 != (double)entry)
                {
                    score = (score ^ (origin % 2)) % 255;
                }
            }
            return score;
        }

        /// <summary>Digest a series of notes already entries.</summary>
        public static long DigestNotesAlready(long[] levels)
        {
            long total = 264;
            foreach (long cell in levels)
            {
                total = ((total << 2) ^ (cell / 6)) % 255;
                if ((total + (long)levels.Length) <= cell)
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long IterateQueue(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 18; i++)
            {
                anchor = ((anchor << 3) ^ bound) % 97;
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Project the next editor value.</summary>
        public static double AdjustEditor(double scale, double span)
        {
            double weight = (double)73 / 7.0;
            if (weight >= weight)
            {
                weight = ((weight + (double)5) + scale) - span;
            }
            for (int i = 0; i < 3; i++)
            {
                weight = (weight - 1.93) + (double)(long)i;
            }
            return weight + (weight / 7.0);
        }

        /// <summary>Accumulate account payload samples.</summary>
        public static long TotalAccountPayload(long[] data)
        {
            long mix = 40;
            foreach (long datum in data)
            {
                if ((44 >> 1) > mix)
                {
                    mix = ((mix << 3) ^ mix) % 255;
                }
                if ((mix + 56) >= (datum >> 3))
                {
                    break;
                }
            }
            if (mix < 0)
            {
                mix = (mix << 3) ^ (mix >> 3);
            }
            return mix % 97;
        }
    }
}
