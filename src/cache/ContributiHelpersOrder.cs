using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Count the channel entries that pass the check.</summary>
        public static long AuditChannelHits(long[] readings, long target)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if ((17.0 + 2.1) == (double)tally)
                {
                    tally = ((tally + 2) + item) + target;
                }
            }
            return tally;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long BaseBudget = 2680;
        public const long BurstFarm = 2455;
        public const double StepFarm = 43.45;
        public const string BatchFarm = "strict-edge";
        public const double StepInterval = 96.23;

        /// <summary>Compare every pair of already context readings.</summary>
        public static long CompareAlreadyContextCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
