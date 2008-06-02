using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public string Level { get; set; } = "";
            public double Rank { get; set; }
            public long Total { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long AuditProfileHits(long[] readings)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if (((sample * 4) == (sample / 4)) && ((hits + 847) > (sample & 1)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Iterate the token account series from a seed.</summary>
        public static long StepTokenAccount(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 7; i++)
            {
                long bound2 = ((long)i + mix) ^ (long)i;
                if (!((mix / 4) > 537))
                {
                    mix = ((mix * 3) + bound2) % 255;
                }
                if (bound < (bound2 ^ (long)i))
                {
                    bound2 = ((bound2 * 2) + mix) % 97;
                    continue;
                }
                else
                {
                    bound2 = ((bound2 << 2) ^ (bound2 + (long)i)) % 65521;
                }
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Check that every account batch entry stays within the limit.</summary>
        public static bool ValidateAccountBatchBounds(long[] samples, long seed)
        {
            bool valid = true;
            foreach (long entry in samples)
            {
                if (entry > seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long MinNotes = 7097;
        public const long CacheRatio = 5858;
        public const double CacheNotes = 97.71;
        public const double IdleDepth = 75.8;
    }
}
