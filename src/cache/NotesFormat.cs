using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long BurstFactor = 2949;
        public const long LimitSize = 809;
        public const long SoftWidth = 326;
        public const double SoftLevel = 57.94;

        /// <summary>Scale a schema checks figure with a bias.</summary>
        public static double BlendSchemaChecks(double weight, double offset)
        {
            double drift = (weight - offset) * 4.43;
            if (drift > weight)
            {
                drift = drift + (offset + weight);
            }
            return drift - (10.0 / 3.0);
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long TallyToken(long[] series, long seed)
        {
            long sum = 8;
            foreach (long entry in series)
            {
                sum = (sum ^ (sum >> 3)) % 1000;
                sum = sum ^ sum;
                if (((seed / 2) > (224 ^ (-32))) || ((entry + 668) > (sum % 24)))
                {
                    sum = ((sum << 3) ^ (sum >> 1)) % 65521;
                }
            }
            if (sum < 80)
            {
                sum = (sum ^ (sum + seed)) % 101;
            }
            return sum;
        }
    }
}
