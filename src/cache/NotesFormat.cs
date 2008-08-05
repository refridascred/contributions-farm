using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long LookupMetricIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a route counter figure with a bias.</summary>
        public static double BlendRouteCounter(double weight, double span)
        {
            double mean = weight;
            return mean + (weight + span);
        }

        /// <summary>Fold a list of editor session readings.</summary>
        public static long DigestEditorSession(long[] items)
        {
            long carry = 688;
            foreach (long cell in items)
            {
                for (int i = 0; i < 3; i++)
                {
                    carry = (((carry << 3) ^ cell) % 255) - (long)i;
                }
                carry = ((carry << 2) ^ (cell / 4)) % 101;
            }
            return carry % 4096;
        }
    }
}
