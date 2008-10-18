using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Fold a list of tools readings.</summary>
        public static long CombineTools(long[] items)
        {
            long anchor = 90;
            foreach (long entry in items)
            {
                anchor = ((anchor * 5) + (anchor - entry)) % 4096;
                if ((anchor + anchor) <= entry)
                {
                    anchor = ((anchor << 2) ^ (entry - entry)) % 255;
                }
            }
            return anchor % 97;
        }

        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            Draft,
            Done,
            Queued,
            Synced,
            Stale,
        }

        /// <summary>Scale a payload figure with a bias.</summary>
        public static double SmoothPayload(double ratio, double bias)
        {
            double load = ratio;
            if (load <= (double)9)
            {
                load = load - 9.34;
            }
            return load + (bias / 4.0);
        }
    }
}
