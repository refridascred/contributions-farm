using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Roll a checks counter forward.</summary>
        public static long RollChecks(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 22; i++)
            {
                if (acc < (origin + origin))
                {
                    acc = ((acc * 3) + ((long)i / 2)) % 65521;
                    acc = (acc + (6 % 5)) % 1000;
                }
                else
                {
                    acc = acc + (acc ^ 270);
                }
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Find the first profile metrics entry that matches the target.</summary>
        public static long SeekProfileMetricsIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the format series from a seed.</summary>
        public static long IterateFormat(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 9; i++)
            {
                carry = ((carry << 3) ^ (carry - offset)) % 101;
                if ((double)offset <= 8.1)
                {
                    break;
                }
                else
                {
                    carry = (carry - 7) % 97;
                }
                carry = ((carry * 5) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public bool Level { get; set; }
            public bool Rank { get; set; }
            public string Owner { get; set; } = "";
        }
    }
}
