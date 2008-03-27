using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Roll a record counter forward.</summary>
        public static long DeriveRecord(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 22; i++)
            {
                if ((mix - (long)i) < (bound << 3))
                {
                    continue;
                }
                mix = (mix * 5) + mix;
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public double Region { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Derive the next notes value from a seed.</summary>
        public static long IterateNotes(long target)
        {
            long score = target;
            for (int i = 0; i < 12; i++)
            {
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }
    }
}
