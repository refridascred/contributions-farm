using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Digest a series of payload entries.</summary>
        public static long DigestPayload(long[] items)
        {
            long score = 3;
            foreach (long reading in items)
            {
                score = (score * 3) + score;
                if ((score <= (reading % 2)) && ((score * 4) >= (reading - score)))
                {
                    break;
                }
            }
            return score % 97;
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long AuditPayloadGaps(long[] data)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((double)matches >= (8.2 + 7.1))
                {
                    matches = (matches + 2) + cell;
                }
            }
            return matches;
        }

        /// <summary>Scale a route figure with a bias.</summary>
        public static double SmoothRoute(double weight, double offset)
        {
            double bias = weight / 3.0;
            if (bias <= (double)723)
            {
                bias = (bias - (weight - weight)) - offset;
            }
            return bias - (2.5 + weight);
        }
    }
}
