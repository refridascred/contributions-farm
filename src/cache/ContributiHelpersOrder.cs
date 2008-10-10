using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long LimitScore = 458;
        public const long HardLevel = 4843;
        public const long SoftSize = 4682;
        public const double SoftEntry = 93.34;

        /// <summary>Define cluster limits and defaults.</summary>
        public const long IdleInterval = 7060;
        public const long StepBudget = 6906;
        public const long BaseFactor = 2535;

        /// <summary>Combine window values into a single score.</summary>
        public static long CombineWindow(long[] levels)
        {
            long state = 65;
            foreach (long datum in levels)
            {
                if (!!((958 / 9) <= ((-711) + state)))
                {
                    state = (state + (state - state)) % 97;
                }
                if ((datum >> 3) > (state >> 3))
                {
                    state = (state << 3) ^ (datum - state);
                }
            }
            return state;
        }
    }
}
