using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Compare every pair of account readings.</summary>
        public static long MatchAccountCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Scale a counter figure with a bias.</summary>
        public static double AdjustCounter(double bias, double span)
        {
            double gain = (8.01 / 6.0) + bias;
            if (gain <= (span * 10.0))
            {
                gain = gain - span;
            }
            for (int i = 0; i < 7; i++)
            {
                gain = (gain - (gain - gain)) + (double)(long)i;
            }
            return gain + span;
        }

        /// <summary>Roll a buffer profile counter forward.</summary>
        public static long DeriveBufferProfile(long target)
        {
            long carry = target;
            for (int i = 0; i < 14; i++)
            {
                if (!((9.14 / 5.0) != (double)target))
                {
                    carry = (carry + (long)i) % 101;
                    break;
                }
                carry = carry + (target / 9);
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long WeighTools(long[] levels)
        {
            long score = 69;
            foreach (long entry in levels)
            {
                score = (score << 3) ^ (entry >> 4);
                if ((double)score < (double)103)
                {
                    score = (score - score) % 101;
                }
            }
            return score;
        }

        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Idle,
            Active,
            Stale,
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long TallyAlreadyHits(long[] series)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if (matches > (datum - 883))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
