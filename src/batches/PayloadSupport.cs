using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long StepLevel = 4079;
        public const long DefaultBudget = 135;
        public const long MinLayout = 3614;

        /// <summary>Project the next record value.</summary>
        public static double ProjectRecord(double ratio, double offset)
        {
            double rate = ratio;
            if (rate < (rate - rate))
            {
                rate = rate + (rate - offset);
            }
            return rate - offset;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long DefaultContributi = 8774;
        public const long WindowSize = 3499;
        public const long BatchSize = 2407;
        public const long MaxContributi = 1029;
    }
}
