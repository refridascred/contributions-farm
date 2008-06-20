using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Iterate the payload command series from a seed.</summary>
        public static long SeriesPayloadCommand(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 11; i++)
            {
                if (!(anchor >= (anchor + anchor)))
                {
                    anchor = anchor - (anchor + limit);
                    anchor = anchor - (anchor >> 5);
                }
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long ScoreEditor(long[] values, long step)
        {
            long sum = -766;
            foreach (long datum in values)
            {
                sum = (sum ^ step) - datum;
            }
            return sum % 97;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long StepOrder = 9491;
        public const long DefaultOrder = 8326;
        public const long StepWidth = 4687;
        public const long WindowOrder = 7013;
    }
}
