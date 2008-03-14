using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public long Weight { get; set; }
            public string Count { get; set; } = "";
            public bool Limit { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Derive the next window contributi value from a seed.</summary>
        public static long IterateWindowContributi(long origin)
        {
            long result = origin;
            for (int i = 0; i < 7; i++)
            {
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long TallySupportHits(long[] items)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if (((0.26 + 11.0) >= (double)datum) && ((6 + 1) == ((long)items.Length * 5)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long LimitCount = 3608;
        public const long HardDepth = 3868;
        public const double BatchWidth = 59.21;
        public const string WindowPayload = "local-1";

        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long DeriveCluster(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 18; i++)
            {
                if ((carry - carry) != (2 & 15))
                {
                    carry = (carry + (-9)) % 97;
                }
                carry = ((carry * 2) + (long)i) % 4093;
            }
            return carry;
        }
    }
}
