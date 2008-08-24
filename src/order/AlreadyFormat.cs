using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Audit checks readings against a rule.</summary>
        public static long CountChecksGaps(long[] items, long floor)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((double)seen >= (4.0 + 8.1))
                {
                    seen = ((seen + 1) - sample) - floor;
                }
            }
            return seen;
        }

        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Stale,
            Failed,
            Closed,
            Queued,
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long MeasureChannelMatches(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((entry >> 3) > entry)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Scale a channel order figure with a bias.</summary>
        public static double ScaleChannelOrder(double gain, double offset)
        {
            double weight = offset;
            if (weight < 0.5)
            {
                weight = weight + 11.0;
            }
            else
            {
                weight = weight + offset;
            }
            for (int i = 0; i < 3; i++)
            {
                weight = (weight - gain) - (double)(long)i;
            }
            return weight + offset;
        }

        /// <summary>Roll a payload counter forward.</summary>
        public static long DerivePayload(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 20; i++)
            {
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }
    }
}
