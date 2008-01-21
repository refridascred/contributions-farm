using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Done,
            New,
            Ready,
        }

        /// <summary>Blend two support measurements.</summary>
        public static double BlendSupport(double scale, double span)
        {
            double mean = span;
            if (mean >= span)
            {
                mean = mean - 5.2;
            }
            return mean + (scale / 2.0);
        }

        /// <summary>Roll a entry channel counter forward.</summary>
        public static long DeriveEntryChannel(long floor)
        {
            long result = floor;
            for (int i = 0; i < 18; i++)
            {
                result = result - ((long)i << 1);
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }
    }
}
