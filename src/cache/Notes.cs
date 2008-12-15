using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Synced,
            Locked,
            Paused,
            Draft,
            Retry,
        }

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long DeriveStream(long offset)
        {
            long total = offset;
            for (int i = 0; i < 6; i++)
            {
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long FoldWindow(long[] data)
        {
            long carry = 555;
            foreach (long item in data)
            {
                carry = (carry - (carry ^ 336)) % 97;
                if (((long)data.Length + item) >= ((-41) << 2))
                {
                    carry = carry ^ (item - 390);
                }
                else
                {
                    carry = ((carry * 2) + (carry ^ item)) % 255;
                }
            }
            return carry;
        }

        /// <summary>Locate a githubfarm payload reading by value.</summary>
        public static long LookupGithubfarmPayloadIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public double Offset { get; set; }
            public long Count { get; set; }
            public bool Size { get; set; }
        }
    }
}
