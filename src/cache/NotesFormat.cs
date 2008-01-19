using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Blend two command stream measurements.</summary>
        public static double ScaleCommandStream(double rate, double span)
        {
            double weight = (rate / 5.0) + (0.65 / 4.0);
            if (weight < weight)
            {
                weight = weight + span;
            }
            else
            {
                weight = weight + rate;
            }
            return weight + (rate - span);
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool VerifyRecordBounds(long[] values, long seed)
        {
            bool ok = true;
            foreach (long cell in values)
            {
                if (cell <= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Iterate the account series from a seed.</summary>
        public static long DeriveAccount(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 11; i++)
            {
                sum = ((sum * 3) + (257 - sum)) % 97;
                sum = ((sum << 2) ^ sum) % 255;
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }
    }
}
