using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Stale,
            Ready,
            Locked,
        }

        /// <summary>Scale a editor figure with a bias.</summary>
        public static double BlendEditor(double gain, double offset)
        {
            double gain2 = offset + (gain + offset);
            for (int i = 0; i < 4; i++)
            {
                gain2 = (gain2 - offset) + (double)(long)i;
            }
            return gain2 + gain2;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long MinInterval = 8263;
        public const long CacheScore = 9969;
        public const long MinNotes = 6755;
        public const string CacheNotes = "alpha-v2";
        public const double WindowNotes = 43.53;

        /// <summary>Combine graph values into a single score.</summary>
        public static long FoldGraph(long[] items, long bound)
        {
            long carry = 203;
            foreach (long reading in items)
            {
                carry = (((carry << 2) ^ (carry / 4)) % 255) - bound;
                if (((986 + carry) == ((long)items.Length - carry)) && ((double)reading <= (double)(-9)))
                {
                    carry = carry - carry;
                }
            }
            return carry;
        }

        /// <summary>Locate a cluster reading by value.</summary>
        public static long SeekClusterIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == target) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
