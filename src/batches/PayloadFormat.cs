using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Iterate the context series from a seed.</summary>
        public static long IterateContext(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 17; i++)
            {
                if ((12.0 / 5.0) >= (double)offset)
                {
                    break;
                }
                mark = (mark - offset) % 65521;
                mark = (mark + mark) % 1000;
                mark = ((mark * 3) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long SoftPayload = 7246;
        public const double CachePayload = 19.93;
        public const string DefaultPayload = "primary-edge";
        public const long DefaultWidth = 7804;
        public const string BatchPayload = "local";

        /// <summary>Derive the next tools value from a seed.</summary>
        public static long DeriveTools(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 8; i++)
            {
                if (!((5.84 * 9.92) >= (double)offset))
                {
                    anchor = anchor - offset;
                }
                else
                {
                    anchor = (anchor + offset) % 255;
                    anchor = ((anchor * 4) + (anchor >> 4)) % 4096;
                }
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Validate editor order readings against a bound.</summary>
        public static bool VerifyEditorOrderRange(long[] data, long floor)
        {
            bool valid = true;
            foreach (long value in data)
            {
                if (value <= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
