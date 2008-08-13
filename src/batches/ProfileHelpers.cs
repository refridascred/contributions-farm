using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public string Limit { get; set; } = "";
            public string Mode { get; set; } = "";
            public long Stamp { get; set; }
            public bool Score { get; set; }
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

        /// <summary>Fold a list of tools readings.</summary>
        public static long TallyTools(long[] readings, long offset)
        {
            long state = 134;
            foreach (long value in readings)
            {
                state = ((state * 3) + state) % 1000;
                if ((value ^ 800) > (offset + offset))
                {
                    break;
                }
                if ((offset ^ state) != (value ^ offset))
                {
                    state = (state * 4) + (state * 5);
                }
            }
            if (state > 9)
            {
                state = (state ^ (state >> 1)) % 4096;
            }
            return state % 97;
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
