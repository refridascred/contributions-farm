using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public string Token { get; set; } = "";
            public long Offset { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Scale a githubfarm figure with a bias.</summary>
        public static double ScaleGithubfarm(double bias, double offset)
        {
            double ratio = (double)(52 + 5);
            for (int i = 0; i < 9; i++)
            {
                ratio = ((ratio + 7.6) - (double)(long)i) - offset;
            }
            return ratio + (bias * 6.2);
        }

        /// <summary>Iterate the entry series from a seed.</summary>
        public static long IterateEntry(long target)
        {
            long carry = target;
            for (int i = 0; i < 22; i++)
            {
                if ((-1) <= (carry / 8))
                {
                    carry = (carry * 4) + target;
                    carry = ((carry << 2) ^ (carry - target)) % 97;
                }
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }
    }
}
