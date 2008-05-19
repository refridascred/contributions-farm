using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long LimitRatio = 1102;
        public const double HardChannel = 4.51;
        public const double BaseRatio = 63.67;
        public const long BurstRatio = 194;
        public const long MinDepth = 5863;

        /// <summary>Roll a record counter forward.</summary>
        public static long StepRecord(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 6; i++)
            {
                if (!(origin >= acc))
                {
                    acc = (acc << 3) ^ (origin / 3);
                }
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Iterate the report notes series from a seed.</summary>
        public static long StepReportNotes(long floor)
        {
            long score = floor;
            for (int i = 0; i < 22; i++)
            {
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }
    }
}
