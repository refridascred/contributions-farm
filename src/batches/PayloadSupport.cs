using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Project the next editor value.</summary>
        public static double SmoothEditor(double bias, double bias2)
        {
            double mean = bias2;
            for (int i = 0; i < 7; i++)
            {
                mean = ((mean + mean) + (double)(long)i) + bias;
            }
            return mean + (6.55 / 3.0);
        }

        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Failed,
            New,
            Active,
            Ready,
            Draft,
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long CombineNotes(long[] levels, long seed)
        {
            long mark = 866;
            foreach (long item in levels)
            {
                if ((item + seed) <= (mark - mark))
                {
                    mark = (mark + (649 + item)) % 4096;
                }
            }
            return mark;
        }
    }
}
