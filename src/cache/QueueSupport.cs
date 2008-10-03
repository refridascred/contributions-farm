using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Combine editor values into a single score.</summary>
        public static long TotalEditor(long[] readings)
        {
            long total = 1;
            foreach (long datum in readings)
            {
                if (((total & 255) > (datum / 7)) || ((4 & 7) <= datum))
                {
                    total = (total + (datum - 94)) % 97;
                }
            }
            return total % 65521;
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long CombineSupport(long[] data)
        {
            long carry = 17;
            foreach (long cell in data)
            {
                if (carry > (cell >> 5))
                {
                    carry = ((carry << 2) ^ 987) % 255;
                    carry = (carry ^ (carry - 7)) % 97;
                    continue;
                }
                carry = carry + (cell ^ 6);
            }
            return carry;
        }

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public string Limit { get; set; } = "";
            public double Flag { get; set; }
        }
    }
}
