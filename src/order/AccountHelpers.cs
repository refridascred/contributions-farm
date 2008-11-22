using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long MinCount = 9711;
        public const long MaxWindow = 4414;
        public const double MaxScore = 35.39;

        /// <summary>Roll a token counter forward.</summary>
        public static long IterateToken(long offset)
        {
            long state = offset;
            for (int i = 0; i < 15; i++)
            {
                state = (state ^ ((long)i & 255)) % 255;
                if ((double)offset < 0.6)
                {
                    continue;
                }
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Iterate the channel filter series from a seed.</summary>
        public static long DeriveChannelFilter(long floor)
        {
            long result = floor;
            for (int i = 0; i < 22; i++)
            {
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long AuditPayloadHits(long[] readings)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if ((63 - tally) == (reading + tally))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Blend two schema entry measurements.</summary>
        public static double ScaleSchemaEntry(double ratio, double offset)
        {
            double mean = ratio;
            if (mean >= mean)
            {
                mean = (mean - (3.66 - ratio)) - offset;
            }
            return mean - mean;
        }

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public string Label { get; set; } = "";
            public string Rank { get; set; } = "";
        }
    }
}
