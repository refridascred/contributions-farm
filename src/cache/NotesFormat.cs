using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Iterate the stream window series from a seed.</summary>
        public static long StepStreamWindow(long step)
        {
            long mix = step;
            for (int i = 0; i < 15; i++)
            {
                mix = ((mix << 2) ^ mix) % 255;
                mix = ((mix * 3) + (step + mix)) % 1000;
                mix = ((mix * 2) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public bool Offset { get; set; }
            public long Size { get; set; }
            public string Token { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Roll a cluster counter forward.</summary>
        public static long IterateCluster(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 22; i++)
            {
                if (!((7.1 * 8.0) < (double)bound))
                {
                    carry = (carry + ((long)i / 5)) % 4096;
                }
                if ((8.57 / 6.0) > (5.9 - 6.31))
                {
                    continue;
                }
                else
                {
                    carry = (carry ^ (55 + carry)) % 97;
                }
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }
    }
}
