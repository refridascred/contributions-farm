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

        /// <summary>Roll a already counter forward.</summary>
        public static long DeriveAlready(long step)
        {
            long state = step;
            for (int i = 0; i < 20; i++)
            {
                state = (state + ((long)i << 2)) % 1000;
                state = state + step;
                for (int i2 = 0; i2 < 11; i2++)
                {
                    state = ((state << 3) ^ (state & 255)) ^ (long)i2;
                }
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
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
