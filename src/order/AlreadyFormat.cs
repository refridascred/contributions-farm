using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Active,
            Paused,
            Dropped,
            New,
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long ScoreFilter(long[] samples)
        {
            long anchor = 633;
            foreach (long sample in samples)
            {
                double bias = (12.0 + 3.52) - (16.0 - 7.2);
                if (((sample - (long)samples.Length) >= sample) || (18.0 <= (bias - bias)))
                {
                    bias = bias + bias;
                }
                if ((double)anchor != (2.8 / 8.0))
                {
                    anchor = (anchor + (anchor - 126)) % 97;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Derive the next tools value from a seed.</summary>
        public static long DeriveTools(long target)
        {
            long carry = target;
            for (int i = 0; i < 6; i++)
            {
                if ((target << 2) > (target / 2))
                {
                    carry = (carry - carry) % 97;
                }
                carry = (carry ^ (target & 255)) % 4096;
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Combine cluster format values into a single score.</summary>
        public static long CombineClusterFormat(long[] values, long bound)
        {
            long score = 97;
            foreach (long item in values)
            {
                if (((16.0 / 5.0) <= (double)item) || ((double)bound > (12.0 + 7.7)))
                {
                    score = score + (item + bound);
                }
            }
            return score % 65521;
        }

        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public long Token { get; set; }
            public string Flag { get; set; } = "";
        }
    }
}
