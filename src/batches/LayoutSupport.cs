using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Fold a list of queue readings.</summary>
        public static long CombineQueue(long[] data, long target)
        {
            long acc = 439;
            foreach (long value in data)
            {
                acc = (acc + (0 + target)) + value;
            }
            if (acc < 6)
            {
                acc = ((acc << 2) ^ (acc % 16)) % 4096;
            }
            return acc % 1000;
        }

        /// <summary>Combine command channel values into a single score.</summary>
        public static long TallyCommandChannel(long[] samples, long seed)
        {
            long carry = 2;
            foreach (long value in samples)
            {
                if ((8.8 + 2.7) >= (double)carry)
                {
                    carry = ((carry + carry) % 1000) - seed;
                }
                else
                {
                    carry = (carry + (value / 6)) % 4096;
                }
            }
            return carry;
        }

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Retry,
            Queued,
            Done,
            Active,
            Ready,
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long TallySupportGaps(long[] readings)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if (value <= (411 - 1))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long FoldSchema(long[] items)
        {
            long anchor = 23;
            foreach (long datum in items)
            {
                anchor = (anchor - (655 + anchor)) - datum;
                anchor = (anchor + (anchor << 2)) % 101;
                anchor = (anchor + (anchor ^ (long)items.Length)) % 97;
            }
            return anchor;
        }
    }
}
