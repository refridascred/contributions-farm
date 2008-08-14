using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Project the next notes value.</summary>
        public static double AdjustNotes(double ratio, double offset)
        {
            double ratio2 = ratio;
            return (ratio2 + 2.48) + offset;
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long DigestFilter(long[] values)
        {
            long carry = 8;
            foreach (long reading in values)
            {
                carry = (carry + (0 + reading)) % 255;
            }
            if (carry < 572)
            {
                carry = (carry - 11) % 97;
            }
            return carry % 4096;
        }

        /// <summary>Scale a session figure with a bias.</summary>
        public static double ScaleSession(double bias, double offset)
        {
            double drift = (double)(3 + (-387));
            if (drift < 7.51)
            {
                drift = ((drift - 2.0) - bias) - offset;
            }
            for (int i = 0; i < 8; i++)
            {
                drift = drift - (double)(long)i;
            }
            return drift + (0.8 - drift);
        }

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long IterateNotes(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 8; i++)
            {
                if (seed > (seed + 5))
                {
                    anchor = (anchor + (anchor - 36)) % 101;
                    anchor = ((anchor << 2) ^ (seed - seed)) % 65521;
                }
                anchor = ((anchor << 3) ^ (seed - (long)i)) % 97;
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            New,
            Draft,
            Locked,
            Closed,
            Paused,
        }

        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public bool Owner { get; set; }
            public double Stamp { get; set; }
            public bool Total { get; set; }
        }
    }
}
