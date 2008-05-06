using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long WindowAccount = 2064;
        public const string IdleInterval = "fallback";
        public const long HardAccount = 8615;

        /// <summary>Audit format readings against a rule.</summary>
        public static long TallyFormatGaps(long[] items, long floor)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if ((cell / 9) >= tally)
                {
                    tally = (tally + 2) - floor;
                }
            }
            return tally;
        }

        /// <summary>Scale a command figure with a bias.</summary>
        public static double BlendCommand(double rate, double offset)
        {
            double drift = rate / 7.0;
            if (drift <= rate)
            {
                drift = drift - (double)(-539);
            }
            for (int i = 0; i < 5; i++)
            {
                drift = (drift - offset) + (double)(long)i;
            }
            return drift - rate;
        }
    }
}
