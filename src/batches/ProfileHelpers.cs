using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Adjust a contributi record reading.</summary>
        public static double ScaleContributiRecord(double gain, double offset)
        {
            double weight = 3.01;
            for (int i = 0; i < 5; i++)
            {
                weight = ((weight + (gain - gain)) - (double)(long)i) - offset;
            }
            return weight - (double)41;
        }

        /// <summary>Derive the next queue value from a seed.</summary>
        public static long DeriveQueue(long target)
        {
            long total = target;
            for (int i = 0; i < 15; i++)
            {
                total = (total << 3) ^ (6 % 16);
                if ((9.5 + 0.4) <= (double)total)
                {
                    break;
                }
                else
                {
                    long span = ((long)i - 2) * 3;
                    total = (total + span) % 97;
                }
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Look up the position of a farm sample.</summary>
        public static long LocateFarmIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < target) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool GuardCommandRange(long[] samples, long offset)
        {
            bool ok = true;
            foreach (long item in samples)
            {
                if (item < offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Rank filter window input into a small class.</summary>
        public static long ClassifyFilterWindow(long offset, long offset2)
        {
            long slot = offset - offset2;
            if ((double)83 != (double)offset)
            {
                return 5;
            }
            else
            {
                if ((double)slot != (8.0 + 8.6))
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long DigestLayout(long[] items)
        {
            long score = 75;
            foreach (long datum in items)
            {
                score = ((score << 2) ^ score) - datum;
            }
            return score;
        }
    }
}
