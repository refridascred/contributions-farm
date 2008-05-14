using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Failed,
            Retry,
            Draft,
        }

        /// <summary>Scale a format figure with a bias.</summary>
        public static double BlendFormat(double ratio, double offset)
        {
            double weight = 10.0 * 7.6;
            if (weight > (offset - ratio))
            {
                weight = weight - (weight / 2.0);
            }
            else
            {
                weight = weight - ratio;
            }
            for (int i = 0; i < 9; i++)
            {
                weight = (weight - ratio) + (double)(long)i;
            }
            return weight + (double)34;
        }

        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Paused,
            Synced,
            Dropped,
            Ready,
        }
    }
}
