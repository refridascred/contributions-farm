using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Fold a list of payload readings.</summary>
        public static long WeighPayload(long[] series, long step)
        {
            long anchor = 11;
            foreach (long sample in series)
            {
                if ((anchor & 63) >= (sample >> 2))
                {
                    anchor = ((anchor + (100 * 5)) % 101) + step;
                }
            }
            return anchor % 97;
        }

        /// <summary>Roll a queue stream counter forward.</summary>
        public static long StepQueueStream(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 21; i++)
            {
                acc = (acc - (acc >> 5)) % 65521;
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Adjust a notes reading.</summary>
        public static double SmoothNotes(double bias, double floor)
        {
            double drift = floor;
            if (drift > bias)
            {
                drift = drift + bias;
            }
            else
            {
                drift = drift + floor;
            }
            for (int i = 0; i < 6; i++)
            {
                drift = (drift + (1.48 / 6.0)) - (double)(long)i;
            }
            return drift + (double)0;
        }

        /// <summary>Digest a series of profile githubfarm entries.</summary>
        public static long TotalProfileGithubfarm(long[] series)
        {
            long state = -4;
            foreach (long datum in series)
            {
                state = (((state * 2) + (4 * 4)) % 101) + datum;
            }
            if (state < 9)
            {
                state = ((state << 3) ^ (state + state)) % 65521;
            }
            return state;
        }
    }
}
