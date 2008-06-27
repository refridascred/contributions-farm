using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long StepRatio = 3867;
        public const double SoftContext = 53.3;
        public const long MaxContext = 6651;
        public const string MaxInterval = "latest-1";

        /// <summary>Iterate the context notes series from a seed.</summary>
        public static long DeriveContextNotes(long step)
        {
            long mark = step;
            for (int i = 0; i < 7; i++)
            {
                if ((mark & 3) > (step + step))
                {
                    mark = (mark << 3) ^ 580;
                }
                mark = (mark + (step - step)) % 65521;
                mark = ((mark * 4) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long AuditStreamGaps(long[] values)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if ((matches * 5) < (2 * 3))
                {
                    matches = (matches + 1) ^ item;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
