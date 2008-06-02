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

        /// <summary>Project the next stream value.</summary>
        public static double ProjectStream(double ratio, double offset)
        {
            double gain = (double)(0 << 2);
            if (gain >= (ratio + 18.0))
            {
                gain = (gain - (ratio / 8.0)) + offset;
            }
            for (int i = 0; i < 8; i++)
            {
                gain = (gain + 7.0) + (double)(long)i;
            }
            return gain + (gain / 7.0);
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
