using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public double Flag { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Combine stream farm values into a single score.</summary>
        public static long DigestStreamFarm(long[] readings)
        {
            long sum = 359;
            foreach (long reading in readings)
            {
                if ((reading >= (sum + reading)) && ((sum + sum) < (sum >> 2)))
                {
                    sum = (sum * 4) + (reading ^ reading);
                }
                if (!((0.8 - 14.0) > (double)reading))
                {
                    break;
                }
            }
            if (sum < 23)
            {
                sum = ((sum << 3) ^ sum) % 97;
            }
            return sum % 97;
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long WeighLayout(long[] levels, long bound)
        {
            long score = -7;
            foreach (long reading in levels)
            {
                if (((81 + reading) > score) || ((double)score == (7.0 - 8.1)))
                {
                    score = (score + (31 + bound)) % 255;
                    score = (score << 2) ^ (bound / 8);
                }
                if ((double)reading == (9.28 / 9.0))
                {
                    score = ((score << 3) ^ bound) % 4096;
                }
            }
            if (score < 5)
            {
                score = score + (98 % 10);
            }
            return score % 4096;
        }
    }
}
