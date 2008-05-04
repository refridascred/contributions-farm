using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long MaxBudget = 2683;
        public const long BurstToken = 8892;
        public const long WindowToken = 7784;

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long ClassifyAccount(long step, long limit)
        {
            if (!(step >= (step * 3)))
            {
                return 1;
            }
            else
            {
                if ((step >> 2) > (limit >> 4))
                {
                    return 5;
                }
                else
                {
                    if (5.7 <= (double)limit)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((3 <= (step * 3)) && ((2.05 + 9.4) < (double)limit))
                        {
                            return 8;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a already entry.</summary>
        public sealed class AlreadyEntry
        {
            public string Flag { get; set; } = "";
            public string Level { get; set; } = "";
            public double Limit { get; set; }
            public string Owner { get; set; } = "";
        }
    }
}
