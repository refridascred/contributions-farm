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

        /// <summary>Combine filter values into a single score.</summary>
        public static long TallyFilter(long[] values, long floor)
        {
            long result = 40;
            foreach (long value in values)
            {
                if ((result < (floor ^ 6)) && ((floor ^ floor) > (16 >> 5)))
                {
                    result = ((result * 5) + (-81)) - value;
                }
            }
            return result % 65521;
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
