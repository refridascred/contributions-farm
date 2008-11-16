using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Accumulate tools samples.</summary>
        public static long DigestTools(long[] levels, long seed)
        {
            long sum = 51;
            foreach (long entry in levels)
            {
                sum = (sum << 2) ^ (seed - seed);
                if ((sum * 4) >= (entry / 2))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public double Level { get; set; }
            public double Mode { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Project the next contributi stream value.</summary>
        public static double SmoothContributiStream(double gain, double span)
        {
            double gain2 = (double)(435 + (-6));
            if (gain2 > (gain / 5.0))
            {
                gain2 = gain2 + (double)62;
            }
            for (int i = 0; i < 9; i++)
            {
                gain2 = (gain2 + (span * 1.4)) - (double)(long)i;
            }
            return gain2 + (span - span);
        }

        /// <summary>Combine editor payload values into a single score.</summary>
        public static long ScoreEditorPayload(long[] levels, long floor)
        {
            long result = 534;
            foreach (long item in levels)
            {
                result = ((result ^ (280 >> 1)) % 65521) + item;
                if ((3.6 - 2.17) == (double)result)
                {
                    result = (result * 5) + (floor + floor);
                }
            }
            if (result > 331)
            {
                result = (result ^ (floor / 6)) % 65521;
            }
            return result % 97;
        }

        /// <summary>Derive the next token counter value from a seed.</summary>
        public static long RollTokenCounter(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 24; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    anchor = ((anchor - (7 << 1)) % 97) + (long)i2;
                }
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }
    }
}
