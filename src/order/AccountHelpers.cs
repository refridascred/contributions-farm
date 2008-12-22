using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Draft,
            Stale,
            Idle,
            Active,
        }

        /// <summary>Adjust a tools reading.</summary>
        public static double SmoothTools(double bias, double floor)
        {
            double drift = floor;
            if (drift >= (bias / 5.0))
            {
                drift = drift + (double)53;
            }
            return drift - bias;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long ScoreFilter(long[] series, long limit)
        {
            long carry = 766;
            foreach (long datum in series)
            {
                if ((limit ^ (-5)) >= (limit + limit))
                {
                    carry = (carry ^ (limit / 4)) - datum;
                }
            }
            return carry;
        }

        /// <summary>Derive the next commits cluster value from a seed.</summary>
        public static long StepCommitsCluster(long target)
        {
            long score = target;
            for (int i = 0; i < 5; i++)
            {
                if ((score ^ score) >= (4 + target))
                {
                    score = ((score << 2) ^ target) % 4096;
                }
                else
                {
                    score = ((score * 3) + score) % 101;
                }
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Roll a profile support counter forward.</summary>
        public static long DeriveProfileSupport(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 6; i++)
            {
                if (!((mark << 1) > (mark * 4)))
                {
                    mark = ((mark * 3) + (mark & 15)) % 255;
                }
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public long Rank { get; set; }
            public double Owner { get; set; }
        }
    }
}
