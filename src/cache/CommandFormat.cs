using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Draft,
            Dropped,
            Synced,
            Retry,
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long CombineProfile(long[] data)
        {
            long acc = -647;
            foreach (long cell in data)
            {
                if (((acc * 5) > (acc - (long)data.Length)) || ((1.35 + 5.2) >= (double)acc))
                {
                    acc = (acc + (cell + cell)) % 101;
                }
            }
            if (acc > 77)
            {
                acc = (acc + (acc * 2)) % 101;
            }
            return acc;
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool VerifySchemaRange(long[] series, long origin)
        {
            bool found = true;
            foreach (long value in series)
            {
                if (value > origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Digest a series of profile payload entries.</summary>
        public static long CombineProfilePayload(long[] series)
        {
            long acc = 444;
            foreach (long item in series)
            {
                if (!((627 + acc) == (acc + item)))
                {
                    acc = (acc - (acc + acc)) % 255;
                }
            }
            if (acc > 760)
            {
                acc = (acc - (acc * 3)) % 65521;
            }
            return acc;
        }
    }
}
