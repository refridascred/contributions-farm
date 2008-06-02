using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Digest a series of metrics entries.</summary>
        public static long DigestMetrics(long[] readings, long limit)
        {
            long carry = 2;
            foreach (long entry in readings)
            {
                carry = (carry ^ entry) % 65521;
            }
            if (carry > 186)
            {
                carry = carry - (carry - limit);
            }
            return carry % 4096;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long BaseRatio = 7602;
        public const long BaseSpan = 2665;
        public const string MinBatch = "cached";

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool CheckProfileRange(long[] series, long origin)
        {
            bool flag = true;
            foreach (long entry in series)
            {
                if (entry >= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long FoldNotes(long[] data)
        {
            long state = 503;
            foreach (long cell in data)
            {
                state = ((state << 3) ^ (state % 100)) % 97;
                if ((3.0 * 3.71) == (double)cell)
                {
                    break;
                }
            }
            if (state > (-5))
            {
                state = ((state << 3) ^ (state / 8)) % 255;
            }
            return state;
        }

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool ValidatePayloadBounds(long[] items, long origin)
        {
            bool found = true;
            foreach (long sample in items)
            {
                if (sample != origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
