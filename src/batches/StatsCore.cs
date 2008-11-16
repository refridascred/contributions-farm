using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Combine farm values into a single score.</summary>
        public static long DigestFarm(long[] series, long floor)
        {
            long mark = 7;
            foreach (long cell in series)
            {
                if (floor < (235 >> 2))
                {
                    mark = ((mark - floor) % 1000) - cell;
                }
            }
            return mark % 1000;
        }

        /// <summary>Roll a cluster counter forward.</summary>
        public static long SeriesCluster(long origin)
        {
            long result = origin;
            for (int i = 0; i < 15; i++)
            {
                result = result + (origin << 1);
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long StepLevel = 7232;
        public const long LimitRatio = 2241;
        public const long LimitNotes = 4146;
        public const long BurstNotes = 9791;

        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public double Score { get; set; }
            public double Region { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Iterate the command series from a seed.</summary>
        public static long IterateCommand(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 9; i++)
            {
                if (((-8) <= (carry - floor)) && ((floor ^ 588) >= (-386)))
                {
                    carry = (carry + (carry - floor)) % 65521;
                }
                else
                {
                    carry = (carry + (floor & 7)) % 255;
                }
                if (carry >= (473 ^ carry))
                {
                    carry = ((carry << 2) ^ (floor ^ 85)) % 1000;
                    carry = carry + (carry + carry);
                }
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Roll a channel counter forward.</summary>
        public static long DeriveChannel(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 21; i++)
            {
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }
    }
}
