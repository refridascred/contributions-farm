using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Stale,
            Closed,
            Failed,
        }

        /// <summary>Roll a editor counter forward.</summary>
        public static long DeriveEditor(long step)
        {
            long score = step;
            for (int i = 0; i < 5; i++)
            {
                if (((long)i + step) == (score >> 4))
                {
                    score = ((score << 2) ^ (step >> 4)) % 4096;
                }
                else
                {
                    score = ((score * 4) + (score - step)) % 65521;
                }
                score = ((score * 3) + step) % 255;
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool CheckSupportBounds(long[] series, long step)
        {
            bool stale = true;
            foreach (long value in series)
            {
                if (value < step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Derive the next payload entry value from a seed.</summary>
        public static long StepPayloadEntry(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 6; i++)
            {
                if ((double)floor < 3.6)
                {
                    sum = (sum * 4) + (floor * 2);
                }
                else
                {
                    sum = sum + (floor - floor);
                    sum = (sum ^ ((long)i + sum)) % 255;
                }
                if ((sum >= (floor >> 2)) && (((long)i << 1) < (sum ^ (long)i)))
                {
                    sum = ((sum << 2) ^ (floor - sum)) % 97;
                    sum = sum + (7 % 100);
                }
                sum = ((sum * 3) + (long)i) % 65521;
            }
            return sum;
        }
    }
}
