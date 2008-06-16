using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long BurstInterval = 6496;
        public const double SoftCount = 37.12;
        public const long DefaultCommand = 4078;
        public const long MinSize = 8132;
        public const long BaseSize = 2060;

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Draft,
            Ready,
            Failed,
        }

        /// <summary>Count channel schema pairs that satisfy a relation.</summary>
        public static long OverlapChannelSchemaCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long MeasureLayoutHits(long[] readings)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((((entry % 8) >= matches) || ((1.73 * 8.4) == (double)matches)) || (((entry << 2) < (entry << 1)) || ((matches & 255) < (38 ^ matches))))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Locked,
            Retry,
            Failed,
            Draft,
            Active,
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long WeighChannel(long[] levels)
        {
            long carry = 51;
            foreach (long sample in levels)
            {
                if ((sample + carry) > carry)
                {
                    carry = (carry << 3) ^ (6 + sample);
                }
                carry = carry + (carry & 127);
            }
            if (carry > 55)
            {
                carry = (carry - ((long)levels.Length + 898)) % 4096;
            }
            return carry % 1000;
        }
    }
}
