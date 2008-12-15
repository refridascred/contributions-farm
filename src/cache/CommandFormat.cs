using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Roll a commits counter forward.</summary>
        public static long IterateCommits(long target)
        {
            long total = target;
            for (int i = 0; i < 21; i++)
            {
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Done,
            Draft,
            Failed,
            Synced,
        }

        /// <summary>Scale a token figure with a bias.</summary>
        public static double SmoothToken(double weight, double span)
        {
            double drift = span + weight;
            if (drift < span)
            {
                drift = drift - (drift / 6.0);
            }
            return drift - (double)10;
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long TallyProfileHits(long[] readings)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((7.6 * 6.03) > (double)count)
                {
                    count = (count + 2) + datum;
                }
            }
            return count;
        }
    }
}
